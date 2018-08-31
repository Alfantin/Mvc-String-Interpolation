using System;
using System.Collections.Generic;

public static class Extensions {

    public static string map<T>(this ICollection<T> model, Func<T, string> template) {
        var ret = "";
        foreach (var i in model) {
            ret += template(i);
        }
        return ret;
    }

}