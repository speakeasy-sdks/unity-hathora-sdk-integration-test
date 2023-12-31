
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Utils
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    internal class QueryParamSerializer
    {
        public static string Serialize(string style, bool explode, string key, string parentKey, object? value) =>
            value == null ? "" : style switch {
                 "deepObject" => SerializeDeepObject(key, parentKey, value),
                 "form" => SerializeDelimited(explode, key, value, ","),
                 "pipeDelimited" => SerializeDelimited(explode, key, value, "|"),
                 _ => throw new ArgumentException($"Invalid query param serialization style [{style}]")
            };

        private static string SerializeDeepObject(string name, string parentName, object value)
        {
            if(Utilities.IsString(value) || Utilities.IsPrimitive(value) || Utilities.IsEnum(value) || Utilities.IsDate(value))
            {
                if(String.IsNullOrEmpty(parentName))
                {
                    return $"{name}={Utilities.ToString(value)}";
                }
                return $"{parentName}[{name}]={Utilities.ToString(value)}";
            }

            if(Utilities.IsDictionary(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var map = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);
                return String.Join("&", from k in map.Keys select $"{SerializeDeepObject(Utilities.ToString(k), name, map[k])}");
            }

            if(Utilities.IsList(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var list = JsonConvert.DeserializeObject<List<object>>(json);

                return String.Join("&", from i in list select SerializeDeepObject(name, parentName, i));
            }

            var props = value.GetType().GetProperties();
            var parsedProps = new List<string>();
            foreach(var prop in props)
            {
                var attrs = (from c in prop.CustomAttributes
                    where c.ConstructorArguments.Count() > 0
                    select c);
                if(attrs.Count() == 0)
                {
                    continue;
                }
                var attr = attrs.Last();

                var key = attr.ConstructorArguments.First().Value;
                var val = prop.GetValue(value);
                if(val == null)
                {
                    continue;
                }

                var strVal = SerializeDeepObject(Utilities.ToString(key), name, val);
                parsedProps.Add(strVal);
            }

            return  String.Join("&", parsedProps);
        }

        private static string SerializeDelimited(bool explode, string name, object value, string delimiter)
        {
            if(value == null || Utilities.IsPrimitive(value) || Utilities.IsDate(value))
            {
                return $"{name}={JsonConvert.SerializeObject(value,  new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }})}";
            }

            if(Utilities.IsString(value))
            {
                return $"{name}={value.ToString()}";
            }

            if(Utilities.IsDictionary(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var map = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);
                if(!explode)
                {
                    return $"{name}={String.Join(delimiter, from k in map.Keys select $"{Utilities.ToString(k)}{delimiter}{Utilities.ToString(map[k])}")}";
                }
                return String.Join("&", from k in map.Keys select $"{Utilities.ToString(k)}={Utilities.ToString(map[k])}");
            }

            if(Utilities.IsList(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var list = JsonConvert.DeserializeObject<List<object>>(json);

                if(!explode)
                {
                    return $"{name}={String.Join(delimiter, from i in list select Utilities.ToString(i))}";
                }
                return String.Join("&", from i in list select $"{name}={Utilities.ToString(i)}");
            }

            var props = value.GetType().GetProperties();
            var parsedProps = new List<string>();
            foreach(var prop in props)
            {
                var attr = (from c in prop.CustomAttributes
                    where c.ConstructorArguments.Count() > 0
                    select c).Last();

                var key = attr.ConstructorArguments.First().Value;
                var val = prop.GetValue(value);
                if(val == null)
                {
                    continue;
                }
                var strVal = Utilities.ToString(val);

                var kvSeparator = explode ? "=" : delimiter;
                parsedProps.Add($"{key}{kvSeparator}{strVal}");
            }

            var separator = explode ? "&" : delimiter;
            var propString =  String.Join(separator, parsedProps);
            return explode ? propString : $"{name}={propString}";
        }
    }
}