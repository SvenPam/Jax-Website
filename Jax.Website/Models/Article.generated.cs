//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Jax.Website.Models
{
	/// <summary>Article</summary>
	[PublishedContentModel("article")]
	public partial class Article : PublishedContentModel, IBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "article";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Article(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Content: This is the content within the article.
		///</summary>
		[ImplementPropertyType("articleContent")]
		public Newtonsoft.Json.Linq.JToken ArticleContent
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("articleContent"); }
		}

		///<summary>
		/// Hero Image
		///</summary>
		[ImplementPropertyType("heroImage")]
		public Umbraco.Web.Models.ImageCropDataSet HeroImage
		{
			get { return Jax.Website.Models.Base.GetHeroImage(this); }
		}

		///<summary>
		/// SEO Meta Data
		///</summary>
		[ImplementPropertyType("sEOMetaData")]
		public Epiphany.SeoMetadata.SeoMetadata SEometaData
		{
			get { return Jax.Website.Models.Base.GetSEometaData(this); }
		}
	}
}
