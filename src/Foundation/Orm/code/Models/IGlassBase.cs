using System;

using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;

using Sitecore.Globalization;
using Sitecore.Data.Items;

namespace SitecoreHelper.Hackathon2021.Dev.Foundation.Orm.Models
{
    /// <summary>
    /// IGlassBase Interface
    /// </summary>
    public partial interface IGlassBase
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [SitecoreId]
        Guid Id { get; }

        [SitecoreItem]
        Item Item { get; set; }

        /// <summary>
        /// Gets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; }

        /// <summary>
        /// Gets the name of the template.
        /// </summary>
        /// <value>
        /// The name of the template.
        /// </value>
        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; }

    }
}