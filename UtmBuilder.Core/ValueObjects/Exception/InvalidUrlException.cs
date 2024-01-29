﻿using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exception;

public partial class InvalidUrlException : System.Exception
{
    private const string DefaultErrorMessage = "Invalid URL";
    //private const string UrlRegexPattern =
    //    @"^(http | https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(: [0 - 9]{ 1,5})? (\\/.*)?$|(http|https):(\\/\\/ localhost:\\d *|\\/\\/ 127\\.([0 - 9] | [1 - 9][0 - 9] | 1[0 - 9][0 - 9] | 2[0 - 4][0 - 9] | 25[0 - 5])\\.([0 - 9] | [1 - 9][0 - 9] | 1[0 - 9][0 - 9] | 2[0 - 4][0 - 9] | 25[0 - 5])\\.([0 - 9] | [1 - 9][0 - 9] | 1[0 - 9][0 - 9] | 2[0 - 4][0 - 9] | 25[0 - 5]))(: [0 - 9]{ 1,5})? (\\/.*)?$";

    public InvalidUrlException(string message = DefaultErrorMessage )
        : base(message){   }

    public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage) 
    {
        if (string.IsNullOrEmpty(address)) {  throw new InvalidUrlException(message); }

        if (!UrlRegex().IsMatch(address)) { throw new InvalidUrlException(); }
    }

    //.NET 7 new resource
    //[GeneratedRegex("^(http | https):(\\\\/\\\\/www\\\\.|\\\\/\\\\/www\\\\.|\\\\/\\\\/|\\\\/\\\\/)[a-z0-9]+([\\\\-\\\\.]{1}[a-z0-9]+)*\\\\.[a-z]{2,5}(: [0 - 9]{ 1,5})? (\\\\/.*)?$|(http|https):(\\\\/\\\\/ localhost:\\\\d *|\\\\/\\\\/ 127\\\\.([0 - 9] | [1 - 9][0 - 9] | 1[0 - 9][0 - 9] | 2[0 - 4][0 - 9] | 25[0 - 5])\\\\.([0 - 9] | [1 - 9][0 - 9] | 1[0 - 9][0 - 9] | 2[0 - 4][0 - 9] | 25[0 - 5])\\\\.([0 - 9] | [1 - 9][0 - 9] | 1[0 - 9][0 - 9] | 2[0 - 4][0 - 9] | 25[0 - 5]))(: [0 - 9]{ 1,5})? (\\\\/.*)?$")]
    [GeneratedRegex("^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$")]
    private static partial Regex UrlRegex();
}
