using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;

namespace ISB.Website.TypeConverters
{
    //public class MultiUrlPickerTypeConverter<T> : TypeConverter
    //{
    //    protected readonly TypeConverter _typeConverter;

    //    public MultiUrlPickerTypeConverter()
    //    {
    //        _typeConverter = TypeDescriptor.GetConverter(typeof(T));
    //        if (_typeConverter == null)
    //            throw new InvalidOperationException("No type converter exists for type " + typeof(T).FullName);
    //    }

    //    protected string[] GetStringArray(string input)
    //    {
    //        string[] result = input.Split(',');
    //        Array.ForEach(result, s => s.Trim());
    //        return result;
    //    }

    //    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    //    {
    //        if (sourceType == typeof(string))
    //        {
    //            string[] items = GetStringArray(sourceType.ToString());
    //            return (items.Count() > 0);
    //        }

    //        return base.CanConvertFrom(context, sourceType);
    //    }

    //    public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
    //    {
    //        var result = JsonConvert.DeserializeObject<List<LinkItem>>(value.ToString());
    //        return result;
    //    }

    //    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
    //    {
    //        if (destinationType == typeof(string))
    //            return string.Join(",", ((IList<T>)value));

    //        return base.ConvertTo(context, culture, value, destinationType);
    //    }
    //}
}