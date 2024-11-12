using Core.Helper.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Core.Helper.Helper;

public static class HttpContextHelper
{
    public static List<TValue> GetValueFromData<TValue>(this HttpContext context, string key)
    {
        var formValues = new List<TValue>();
        var formFieldValues = context.Request.Form
            .Where(x => x.Key.ToString().Equals(key))
            .Select(x=>x.Value).FirstOrDefault();
        if (formFieldValues.Count > 0)
        {
            formValues.AddRange(formFieldValues.OfType<string>()
                .Select(JsonConvert.DeserializeObject<TValue>).OfType<TValue>());
        };
        return formValues;
    }

    public static Search GetSearchInQueryString(this HttpContext context)
    {
        var search = new Search()
        {
            Fields = []
        };
        search.Fields.AddRange(context.Request.Query
            .Select(x
                => new Field(x.Key, x.Value.ToString())));
        return search;
    }
}
