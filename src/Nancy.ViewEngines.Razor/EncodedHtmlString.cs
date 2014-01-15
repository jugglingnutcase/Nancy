using System;
using Nancy.Helpers;

namespace Nancy.ViewEngines.Razor
{
    /// <summary>
    /// An html string that is encoded.
    /// </summary>
    public class EncodedHtmlString : IHtmlString
    {
        /// <summary>
        /// Represents the empty <see cref="EncodedHtmlString"/>. This field is readonly.
        /// </summary>
        public static readonly EncodedHtmlString Empty = new EncodedHtmlString(string.Empty);

        private readonly Lazy<string> encoderFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="EncodedHtmlString"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public EncodedHtmlString(string value)
        {
            encoderFactory = new Lazy<string>(() => HttpUtility.HtmlEncode(value));
        }

        /// <summary>
        /// Returns an HTML-encoded string.
        /// </summary>
        /// <returns>An HTML-encoded string.</returns>
        public string ToHtmlString()
        {
            return encoderFactory.Value;
        }

        public static implicit operator EncodedHtmlString(string value)
        {
            return new EncodedHtmlString(value);
        }
    }
}