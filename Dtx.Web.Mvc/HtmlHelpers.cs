using System.Linq;
using System.Web.Mvc.Html;
//using CaptchaMvc.HtmlHelpers;

namespace Dtx.Web.Mvc
{
	public static class HtmlHelpers
	{
		static HtmlHelpers()
		{
		}

		public static string ActionLinkClassNames
		{
			get
			{
				return ("btn btn-default");
			}
		}

		//public static System.Web.IHtmlString DtxBeginForm(this System.Web.Mvc.HtmlHelper html, string id)
		//{
		//	string strResult =
		//		string.Format("<form id='{0}' name='{0}'>", id);

		//	return (html.Raw(strResult));
		//}

		//public static System.Web.IHtmlString DtxEndForm(this System.Web.Mvc.HtmlHelper html)
		//{
		//	string strResult =
		//		string.Format("</form>");

		//	return (html.Raw(strResult));
		//}

		//public static System.Web.IHtmlString DtxGrid(this System.Web.Mvc.HtmlHelper html, string id)
		//{
		//	string strResult =
		//		string.Format("<div id='{0}' class='k-content k-rtl grid'></div>", id);

		//	return (html.Raw(strResult));
		//}

		//public static System.Web.IHtmlString DtxCaptcha
		//	(this System.Web.Mvc.HtmlHelper html, int labelColumn = 3)
		//{
		//	string strResult = string.Empty;

		//	if (Infrastructure.ApplicationSettings.Instance.IsCaptchaImageEnabled)
		//	{
		//		strResult +=
		//			"<div class='form-group control-wrapper'>";

		//		strResult +=
		//			string.Format("<div class='col-sm-{0}'>", labelColumn);

		//		strResult +=
		//			@Resources.CaptchaImage.Message01;

		//		strResult += " *";
		//		strResult += "<br />";
		//		strResult += "<span style='color: red'>";
		//		strResult += "(بزرگی و کوچکی حروف انگليسی اهميتی ندارد)";
		//		strResult += "</span>";
		//		strResult += "</div>";

		//		strResult +=
		//			string.Format("<div class='col-sm-{0}'>", (12 - labelColumn));

		//		strResult +=
		//			html.Captcha(6, MVC.Shared.Views._Partial_CaptchaImage).ToHtmlString();

		//		strResult += "</div>";
		//		strResult += "</div>";
		//	}

		//	return (html.Raw(strResult));
		//}

		//public static System.Web.IHtmlString DtxBeginPanel(this System.Web.Mvc.HtmlHelper html,
		//	Enums.PanelTypes type = Enums.PanelTypes.Default)
		public static System.Web.IHtmlString
			DtxBeginPanel(this System.Web.Mvc.HtmlHelper html, Enums.PanelTypes type = Enums.PanelTypes.Primary, string classNames = "")
		{
			string strClass = "panel panel-";

			switch (type)
			{
				case Enums.PanelTypes.Info:
				{
					strClass += "info";
					break;
				}

				case Enums.PanelTypes.Danger:
				{
					strClass += "danger";
					break;
				}

				case Enums.PanelTypes.Primary:
				{
					strClass += "primary";
					break;
				}

				case Enums.PanelTypes.Success:
				{
					strClass += "success";
					break;
				}

				case Enums.PanelTypes.Warning:
				{
					strClass += "warning";
					break;
				}

				default:
				{
					strClass += "default";
					break;
				}
			}

			if (string.IsNullOrWhiteSpace(classNames) == false)
			{
				strClass =
					string.Format("{0} {1}", strClass, classNames.Trim());
			}

			string strResult =
				string.Format("<div class='{0}'>", strClass);

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxEndPanel(this System.Web.Mvc.HtmlHelper html)
		{
			string strResult = "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxBeginPanelHeading(this System.Web.Mvc.HtmlHelper html, string id = null)
		{
			string strResult = string.Empty;

			if (string.IsNullOrWhiteSpace(id))
			{
				strResult =
					"<div class='panel-heading'>";
			}
			else
			{
				strResult =
					string.Format("<div class='panel-heading' id='{0}'>", id);
			}

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxEndPanelHeading(this System.Web.Mvc.HtmlHelper html)
		{
			string strResult = "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString
			DtxBeginPanelBody(this System.Web.Mvc.HtmlHelper html, string classNames = "", string style = "")
		{
			string strResult = string.Empty;

			string strClassNames = "panel-body form-horizontal";

			if (string.IsNullOrWhiteSpace(classNames) == false)
			{
				strClassNames =
					string.Format("{0} {1}", strClassNames, classNames);
			}

			if (string.IsNullOrWhiteSpace(style))
			{
				strResult =
					string.Format("<div class='{0}'>", strClassNames);
			}
			else
			{
				strResult =
					string.Format("<div class='{0}' style='{1}'>", strClassNames, style);
			}

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxEndPanelBody(this System.Web.Mvc.HtmlHelper html)
		{
			string strResult = "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxBeginPanelFooter(this System.Web.Mvc.HtmlHelper html)
		{
			string strResult = "<div class='panel-footer'>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxEndPanelFooter(this System.Web.Mvc.HtmlHelper html)
		{
			string strResult = "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxPanelTitle(this System.Web.Mvc.HtmlHelper html, string title)
		{
			string strResult =
				string.Format("<h3 class='panel-title'>{0}</h3>", title);

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxDelete
			(this System.Web.Mvc.HtmlHelper html,
			string id = null, bool enable = true, int columnOffset = 3)
		{
			return (DtxSubmit(html, Resources.Buttons.Delete, id, displayReset: false, enable: enable, columnOffset: columnOffset));
		}

		public static System.Web.IHtmlString DtxSubmit
			(this System.Web.Mvc.HtmlHelper html,
			string caption = null, string id = null,
			bool displayReset = true, bool enable = true, int columnOffset = 3)
		{
			string strResult = string.Empty;

			if (string.IsNullOrWhiteSpace(caption))
			{
				caption =
					Resources.Buttons.Submit;
			}

			strResult += "<div class='form-group'>";

			strResult +=
				string.Format("<div class='btn-wrapper col-sm-{0} col-sm-offset-{1}'>",
				(12 - columnOffset), columnOffset);

			strResult +=
				DtxSimpleSubmit(html, caption, id);

			if (displayReset)
			{
				strResult +=
					" " + DtxSimpleReset(html, Resources.Buttons.Reset);
			}

			strResult += "</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxButton
			(this System.Web.Mvc.HtmlHelper html,
			string caption = null, string id = null,
			bool displayReset = true, int columnOffset = 3)
		{
			string strResult = string.Empty;

			if (string.IsNullOrWhiteSpace(caption))
			{
				caption =
					Resources.Buttons.Submit;
			}

			strResult += "<div class='form-group'>";

			strResult +=
				string.Format("<div class='col-sm-{0} col-sm-offset-{1}'>",
				(12 - columnOffset), columnOffset);

			strResult +=
				DtxSimpleButton(html, id: id, caption: caption);

			if (displayReset)
			{
				strResult +=
					" " + DtxSimpleReset(html, caption: Resources.Buttons.Reset);
			}

			strResult += "</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxActionLink
			(this System.Web.Mvc.HtmlHelper html,
			string linkText,
			System.Web.Mvc.ActionResult actionResult = null,
			Enums.ActionLinksTypes type = Enums.ActionLinksTypes.Undefined,
			object htmlAttributes = null,
			bool checkPermission = true)
		{
			System.Web.Mvc.IT4MVCActionResult
				oT4MVCActionResult = actionResult as System.Web.Mvc.IT4MVCActionResult;

			if (oT4MVCActionResult == null)
			{
				return (null);
			}

			if (checkPermission)
			{
				string strAreaName = string.Empty;

				object objArea =
					oT4MVCActionResult.RouteValueDictionary["Area"];

				if (objArea != null)
				{
					if (string.IsNullOrWhiteSpace(objArea.ToString()) == false)
					{
						strAreaName = objArea.ToString();
					}
				}

				if (Security.Utility
					.CheckPermission(strAreaName, oT4MVCActionResult.Controller, oT4MVCActionResult.Action) == false)
				{
					return (null);
				}
			}

			System.Web.Mvc.TagBuilder oTagBuilder = new System.Web.Mvc.TagBuilder("a");

			switch (type)
			{
				case Enums.ActionLinksTypes.Edit:
				{
					oTagBuilder.Attributes["title"] = linkText;
					oTagBuilder.Attributes["data-placement"] = "top";
					oTagBuilder.Attributes["data-toggle"] = "tooltip";

					oTagBuilder.InnerHtml =
						"<span class='glyphicon glyphicon-edit'></span>";

					break;
				}

				case Enums.ActionLinksTypes.Create:
				{
					oTagBuilder.Attributes["title"] = linkText;
					oTagBuilder.Attributes["data-placement"] = "top";
					oTagBuilder.Attributes["data-toggle"] = "tooltip";

					oTagBuilder.InnerHtml =
						"?????";
					break;
				}

				case Enums.ActionLinksTypes.Delete:
				{
					oTagBuilder.Attributes["title"] = linkText;
					oTagBuilder.Attributes["data-placement"] = "top";
					oTagBuilder.Attributes["data-toggle"] = "tooltip";

					oTagBuilder.InnerHtml =
						"<span class='glyphicon glyphicon-trash'></span>";

					break;
				}

				case Enums.ActionLinksTypes.Details:
				{
					oTagBuilder.Attributes["title"] = linkText;
					oTagBuilder.Attributes["data-placement"] = "top";
					oTagBuilder.Attributes["data-toggle"] = "tooltip";

					oTagBuilder.InnerHtml =
						"<span class='glyphicon glyphicon-eye-open'></span>";

					break;
				}

				case Enums.ActionLinksTypes.SimpleLink:
				{
					oTagBuilder.InnerHtml = linkText;

					break;
				}

				default:
				{
					oTagBuilder.InnerHtml = linkText;

					oTagBuilder.AddCssClass("btn btn-info");

					break;
				}
			}

			System.Web.Mvc.UrlHelper oUrlHelper =
				new System.Web.Mvc.UrlHelper(html.ViewContext.RequestContext);

			oTagBuilder.Attributes["href"] =
				oUrlHelper.Action
				(oT4MVCActionResult.Action,
				oT4MVCActionResult.Controller,
				oT4MVCActionResult.RouteValueDictionary);

			if (htmlAttributes != null)
			{
				var oHtmlAttributes =
					System.Web.Mvc.HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

				if (oHtmlAttributes.ContainsKey("class"))
				{
					oTagBuilder.AddCssClass(oHtmlAttributes["class"].ToString());
				}

				oTagBuilder.MergeAttributes
					(new System.Web.Routing.RouteValueDictionary(htmlAttributes), replaceExisting: false);
			}

			return (html.Raw(oTagBuilder.ToString()));
		}

		public static System.Web.IHtmlString DtxDisplayNameAndValue
			(this System.Web.Mvc.HtmlHelper html,
			string caption, object value,
			Enums.DisplayValueTypes displayValueType = Enums.DisplayValueTypes.Undefined,
			int labelColumn = 3, System.Web.Mvc.ActionResult actionResult = null)
		{
			System.Web.Mvc.IT4MVCActionResult oT4MVCActionResult = null;

			if (actionResult != null)
			{
				oT4MVCActionResult =
					actionResult as System.Web.Mvc.IT4MVCActionResult;

				if (oT4MVCActionResult == null)
				{
					return (null);
				}
			}

			string strResult = string.Empty;

			strResult += "<div class='row'>";

			// **************************************************
			string strLabelStyle =
				"background-color: #f5f5f5; color: black; margin: 0px; padding: 4px; border: 1px solid darkgray";

			string strCaption = caption;
			if (string.IsNullOrWhiteSpace(strCaption))
			{
				strCaption = string.Empty;
			}

			strResult +=
				string.Format("<div class='col-sm-{0}' style='{1}'>",
				labelColumn, strLabelStyle);

			strResult += strCaption;

			strResult += "</div>";
			// **************************************************

			strResult +=
				string.Format("<div class='col-sm-{0}'>", (12 - labelColumn));

			string strValue = "-----";

			if (value != null)
			{
				switch (displayValueType)
				{
					case Enums.DisplayValueTypes.Currency:
					{
						strValue =
							Dtx.Text.Convert.DisplayFormattedNumber(value);

						strValue += " ريال";

						break;
					}

					case Enums.DisplayValueTypes.Date:
					{
						try
						{
							System.DateTime sDateTime =
								System.Convert.ToDateTime(value);

							//Models.ComplexTypes.CustomDateTime oCustomDateTime =
							//	value as Models.ComplexTypes.CustomDateTime;

							strValue =
								DisplayDateTime(html, sDateTime, displayTime: false).ToHtmlString();
						}
						catch
						{
						}

						break;
					}

					case Enums.DisplayValueTypes.DateTime:
					{
						try
						{
							System.DateTime sDateTime =
								System.Convert.ToDateTime(value);

							//Models.ComplexTypes.CustomDateTime oCustomDateTime =
							//	value as Models.ComplexTypes.CustomDateTime;

							strValue =
								DisplayDateTime(html, sDateTime, displayTime: true).ToHtmlString();
						}
						catch
						{
						}

						break;
					}

					case Enums.DisplayValueTypes.Number:
					{
						strValue =
							Dtx.Text.Convert.DisplayFormattedNumber(value);

						break;
					}

					case Enums.DisplayValueTypes.Raw:
					{
						strValue =
							html.Raw(value).ToHtmlString();

						break;
					}

					case Enums.DisplayValueTypes.Url:
					{
						strValue =
							string.Format("<a href='{0}'>{0}</a>", value);

						break;
					}

					case Enums.DisplayValueTypes.PhoneNumber:
					{
						strValue =
							Dtx.Text.Convert.DigitsToUnicode(value.ToString());

						break;
					}

					default:
					{
						strValue =
							value.ToString();

						break;
					}
				}
			}

			if (actionResult == null)
			{
				strResult += strValue;
			}
			else
			{
				System.Web.Mvc.UrlHelper oUrlHelper =
					new System.Web.Mvc.UrlHelper(html.ViewContext.RequestContext);

				//strResult += oUrlHelper.Action
				//	(oT4MVCActionResult.Action,
				//	oT4MVCActionResult.Controller,
				//	oT4MVCActionResult.RouteValueDictionary);

				strResult +=
					html.ActionLink(linkText: strValue,
					actionName: oT4MVCActionResult.Action,
					controllerName: oT4MVCActionResult.Controller,
					routeValues: oT4MVCActionResult.RouteValueDictionary,
					htmlAttributes: null);
			}

			strResult += "	</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxDisplayNameAndValueFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			Enums.DisplayValueTypes displayValueType = Enums.DisplayValueTypes.Undefined, int labelColumn = 3,
			string caption = null, System.Web.Mvc.ActionResult actionResult = null)
		{
			System.Web.Mvc.IT4MVCActionResult oT4MVCActionResult = null;

			if (actionResult != null)
			{
				oT4MVCActionResult =
					actionResult as System.Web.Mvc.IT4MVCActionResult;

				if (oT4MVCActionResult == null)
				{
					return (null);
				}
			}

			string strResult = string.Empty;

			strResult += "<div class='row'>";

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			// **************************************************
			string strLabelStyle =
				"background-color: #f5f5f5; color: black; margin: 0px; padding: 4px; border: 1px solid darkgray";

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			string strCaption = caption;

			if (string.IsNullOrWhiteSpace(strCaption))
			{
				strCaption =
					oModelMetadata.DisplayName ??
					oModelMetadata.PropertyName ??
					strHtmlFieldName.Split('.').Last();
			}

			strResult +=
				string.Format("<div class='col-sm-{0}' style='{1}'>",
				labelColumn, strLabelStyle);

			strResult += strCaption;

			strResult += "</div>";
			// **************************************************

			strResult +=
				string.Format("<div class='col-sm-{0}'>", (12 - labelColumn));

			object objValue =
				oModelMetadata.Model;

			string strValue = "-----";

			if (objValue != null)
			{
				switch (displayValueType)
				{
					case Enums.DisplayValueTypes.Percent:
					{
						strValue =
							Dtx.Text.Convert.DisplayFormattedNumber(objValue);

						strValue += " درصد";

						break;
					}

					case Enums.DisplayValueTypes.Currency:
					{
						strValue =
							Dtx.Text.Convert.DisplayFormattedNumber(objValue);

						strValue += " ريال";

						break;
					}

					case Enums.DisplayValueTypes.Date:
					{
						try
						{
							Models.ComplexTypes.CustomDateTime oCustomDateTime =
								objValue as Models.ComplexTypes.CustomDateTime;

							strValue =
								DisplayDateTime(html, oCustomDateTime, displayTime: false).ToHtmlString();
						}
						catch
						{
						}

						break;
					}

					case Enums.DisplayValueTypes.DateTime:
					{
						try
						{
							Models.ComplexTypes.CustomDateTime oCustomDateTime =
								objValue as Models.ComplexTypes.CustomDateTime;

							strValue =
								DisplayDateTime(html, oCustomDateTime, displayTime: true).ToHtmlString();
						}
						catch
						{
						}

						break;
					}

					case Enums.DisplayValueTypes.Number:
					{
						strValue =
							Dtx.Text.Convert.DisplayFormattedNumber(objValue);

						break;
					}

					case Enums.DisplayValueTypes.Raw:
					{
						strValue =
							html.Raw(objValue).ToHtmlString();

						break;
					}

					case Enums.DisplayValueTypes.Url:
					{
						strValue =
							string.Format("<a href='{0}'>{0}</a>", objValue);

						break;
					}

					case Enums.DisplayValueTypes.EmailAddress:
					{
						strValue =
							string.Format("<a href='mailto:{0}'>{0}</a>", objValue);

						break;
					}

					case Enums.DisplayValueTypes.PhoneNumber:
					{
						strValue =
							Dtx.Text.Convert.DigitsToUnicode(objValue.ToString());

						break;
					}

					default:
					{
						strValue =
							html.DisplayFor(expression).ToHtmlString();

						break;
					}
				}
			}

			if (actionResult == null)
			{
				strResult += strValue;
			}
			else
			{
				System.Web.Mvc.UrlHelper oUrlHelper =
					new System.Web.Mvc.UrlHelper(html.ViewContext.RequestContext);

				//strResult += oUrlHelper.Action
				//	(oT4MVCActionResult.Action,
				//	oT4MVCActionResult.Controller,
				//	oT4MVCActionResult.RouteValueDictionary);

				strResult +=
					html.ActionLink(linkText: strValue,
					actionName: oT4MVCActionResult.Action,
					controllerName: oT4MVCActionResult.Controller,
					routeValues: oT4MVCActionResult.RouteValueDictionary,
					htmlAttributes: null);
			}

			strResult += "	</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxLabelDateFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			bool readOnly = false, int labelColumn = 3)
		{
			string strResult = string.Empty;

			strResult +=
				"<div class='form-group control-wrapper'>";

			strResult +=
				DtxLabelFor(html, expression, labelColumn, ignoreFor: true);

			strResult +=
				"<div class='control col-sm-" + (12 - labelColumn) + "'>";

			strResult +=
				html.EditorFor(expression).ToHtmlString();

			strResult +=
				html.ValidationMessageFor(expression);

			strResult += "</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxLabelTextBoxFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> textBoxAttributes = null,
			bool leftToRight = false, bool readOnly = false, int labelColumn = 3, string hint = null)
		{
			string strResult = string.Empty;

			// **************************************************
			if (textBoxAttributes == null)
			{
				textBoxAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			if (leftToRight)
			{
				textBoxAttributes.Add("class", "ltr");
			}
			// **************************************************

			strResult += "<div class='form-group'>";

			strResult += DtxLabelFor(html, expression, labelColumn);

			if (string.IsNullOrWhiteSpace(hint))
			{
				strResult +=
					"<div class='control col-sm-" + (12 - labelColumn) + "'>";
			}
			else
			{
				strResult +=
					"<div class='control col-sm-" + (12 - labelColumn - 3) + "'>";
			}

			strResult +=
				DtxTextBoxFor(html, expression, htmlAttributes: textBoxAttributes, readOnly: readOnly);

			strResult +=
				html.ValidationMessageFor(expression);

			//strResult +=
			//	DtxTextBoxFor(html, expression, htmlAttributes: textBoxAttributes, readOnly: readOnly);

			strResult += "</div>";

			if (string.IsNullOrWhiteSpace(hint) == false)
			{
				strResult +=
					"<div class='col-sm-3'>";

				strResult += hint.Trim();

				strResult += "</div>";
			}

			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxLabelPasswordFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> textBoxAttributes = null, int labelColumn = 3)
		{
			string strResult = string.Empty;

			// **************************************************
			if (textBoxAttributes == null)
			{
				textBoxAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			textBoxAttributes.Add("class", "ltr");
			// **************************************************

			strResult += "<div class='form-group control-wrapper'>";

			strResult += DtxLabelFor(html, expression, labelColumn);

			strResult += "	<div class='control col-sm-" + (12 - labelColumn) + "'>";

			strResult +=
				DtxPasswordFor(html, expression, htmlAttributes: textBoxAttributes);

			strResult +=
				html.ValidationMessageFor(expression);

			strResult += "	</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxLabelTextAreaFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			bool leftToRight = false, bool readOnly = false, int labelColumn = 3, bool ignoreLabel = false)
		{
			string strResult = string.Empty;

			// **************************************************
			System.Collections.Generic.Dictionary<string, object>
				oTextAreaAttributes = new System.Collections.Generic.Dictionary<string, object>();

			oTextAreaAttributes.Add("rows", "4");

			if (leftToRight)
			{
				oTextAreaAttributes.Add("class", "ltr");
			}
			// **************************************************

			strResult += "<div class='row form-group'>";

			if (ignoreLabel == false)
			{
				strResult += DtxLabelFor(html, expression, labelColumn);

				strResult += "	<div class='control col-sm-" + (12 - labelColumn) + "'>";
			}
			else
			{
				strResult += "	<div class='control col-sm-12'>";
			}

			strResult += DtxTextAreaFor(html, expression, oTextAreaAttributes, readOnly);
			strResult += html.ValidationMessageFor(expression);

			strResult += "	</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		/// <summary>
		/// Note: The Drop Down List Selected Item does not related to [Expression] or [Model Value]!
		/// It depends on only [SelectedValue] that you defines in ViewBag in action!
		/// </summary>
		public static System.Web.IHtmlString DtxLabelDropDownListFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			string optionLabel = null,
			bool leftToRight = false,
			bool readOnly = false,
			int labelColumn = 3)
		{
			string strResult = string.Empty;

			// **************************************************
			string strCssClass = "form-control";

			if (leftToRight)
			{
				strCssClass =
					string.Format("{0} ltr", strCssClass);
			}
			// **************************************************

			strResult += "<div class='form-group control-wrapper'>";

			strResult += DtxLabelFor(html, expression, labelColumn);

			strResult += "	<div class='control col-sm-" + (12 - labelColumn) + "'>";

			// **************************************************
			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);
			// **************************************************

			object oHtmlAttributes = null;

			if (readOnly)
			{
				optionLabel = null;

				oHtmlAttributes = new { @class = strCssClass, disabled = "disabled" };
			}
			else
			{
				if (oModelMetadata.IsRequired == false)
				{
					if (optionLabel == null)
					{
						optionLabel =
							Resources.Messages.YouCanSelectAnItem;
					}

					oHtmlAttributes = new { @class = strCssClass };
				}
				else
				{
					if (optionLabel == null)
					{
						optionLabel =
							Resources.Messages.YouShouldSelectAnItem;
					}

					// **************************************************
					string strErrorMessage =
						Resources.Messages.RequiredValidation;

					string strDisplayName =
						oModelMetadata.DisplayName;

					if (string.IsNullOrWhiteSpace(strDisplayName) == false)
					{
						strErrorMessage =
							string.Format(Resources.Messages.RequiredValidation, strDisplayName);
					}
					// **************************************************

					oHtmlAttributes =
						new { @class = strCssClass, data_val = "true", data_val_required = strErrorMessage };
				}
			}

			strResult +=
				html.DropDownList
				(name: strHtmlFieldName, selectList: null, optionLabel: optionLabel, htmlAttributes: oHtmlAttributes);

			strResult += html.ValidationMessageFor(expression);

			strResult += "	</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		//public static System.Web.IHtmlString DtxLabelDropDownListFor<TModel, TValue>
		//	(this System.Web.Mvc.HtmlHelper<TModel> html,
		//	System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
		//	string optionLabel = null, bool leftToRight = false, bool readOnly = false,
		//	bool searchable = false, int labelColumn = 3)
		//{
		//	string strResult = string.Empty;

		//	// **************************************************
		//	System.Collections.Generic.Dictionary<string, object>
		//		oDropDownListAttributes = new System.Collections.Generic.Dictionary<string, object>();

		//	if (leftToRight)
		//	{
		//		oDropDownListAttributes.Add("class", "ltr");
		//	}
		//	// **************************************************

		//	strResult += "<div class='form-group control-wrapper'>";

		//	strResult += DtxLabelFor(html, expression, labelColumn, ignoreFor: true);

		//	strResult += "	<div class='control col-sm-" + (12 - labelColumn) + "'>";

		//	strResult += DtxDropDownListFor(html, expression, oDropDownListAttributes, optionLabel, readOnly);
		//	strResult += html.ValidationMessageFor(expression);

		//	strResult += "	</div>";
		//	strResult += "</div>";

		//	return (html.Raw(strResult));
		//}

		//public static System.Web.IHtmlString DtxLabelAutoCompleteFor<TModel, TValue>
		//	(this System.Web.Mvc.HtmlHelper<TModel> html,
		//	System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
		//	System.Web.Mvc.ActionResult actionResult = null,
		//	string placeHolder = null, bool leftToRight = false, bool readOnly = false,
		//	int labelColumn = 3)
		//{
		//	string strResult = string.Empty;

		//	// **************************************************
		//	System.Collections.Generic.Dictionary<string, object>
		//		oDropDownListAttributes = new System.Collections.Generic.Dictionary<string, object>();

		//	if (leftToRight)
		//	{
		//		oDropDownListAttributes.Add("class", "ltr");
		//	}
		//	// **************************************************

		//	strResult += "<div class='form-group'>";

		//	strResult += DtxLabelFor(html, expression, labelColumn, ignoreFor: true);

		//	strResult += "	<div class='col-sm-" + (12 - labelColumn) + " k-rtl'>";

		//	strResult += DtxAutoCompleteFor(html, expression, actionResult, oDropDownListAttributes, placeHolder, readOnly);
		//	strResult += html.ValidationMessageFor(expression);

		//	strResult += "	</div>";
		//	strResult += "</div>";

		//	return (html.Raw(strResult));
		//}

		public static System.Web.IHtmlString DtxCheckBoxFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
			bool readOnly = false, int labelColumn = 3)
		{
			string strResult = string.Empty;

			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			// **************************************************
			object objChecked = oModelMetadata.Model;

			bool blnChecked = false;
			if ((objChecked != null) &&
				(System.Convert.ToBoolean(objChecked)))
			{
				blnChecked = true;
			}
			// **************************************************

			// **************************************************
			bool blnReadOnly = false;

			if (oModelMetadata == null)
			{
				if (readOnly)
				{
					blnReadOnly = true;
				}
			}
			else
			{
				if ((readOnly) || (oModelMetadata.IsReadOnly))
				{
					blnReadOnly = true;
				}
			}
			// **************************************************

			string strLabelText =
				oModelMetadata.DisplayName ??
				oModelMetadata.PropertyName ??
				strHtmlFieldName.Split('.').Last();

			strResult += "<div class='form-group selective-wrapper'>";

			strResult +=
				string.Format("<div class='col-sm-{0} col-sm-offset-{1} checkbox'>",
				(12 - labelColumn), labelColumn);

			strResult +=
				string.Format("<label>");

			if (blnReadOnly == false)
			{
				if (blnChecked == false)
				{
					strResult +=
						string.Format("<input id='{0}' name='{0}' type='checkbox' value='true' />", strHtmlFieldName);
				}
				else
				{
					strResult +=
						string.Format("<input id='{0}' name='{0}' type='checkbox' value='true' checked='checked' />", strHtmlFieldName);
				}
			}
			else
			{
				if (blnChecked == false)
				{
					strResult +=
						string.Format("<input id='{0}' name='{0}' type='checkbox' value='true' disabled='disabled' />", strHtmlFieldName);
				}
				else
				{
					strResult +=
						string.Format("<input id='{0}' name='{0}' type='checkbox' value='true' disabled='disabled' checked='checked' />", strHtmlFieldName);
				}
			}

			strResult +=
				string.Format("<input name='{0}' type='hidden' value='false' />", strHtmlFieldName);

			if (string.IsNullOrWhiteSpace(strLabelText) == false)
			{
				strResult += " " + strLabelText;
			}

			strResult += "</label>";
			strResult += "</div>";
			strResult += "</div>";

			return (html.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxDropDownListFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
			string optionLabel = null, bool readOnly = false, bool searchable = false)
		{
			string strResult = string.Empty;

			if (optionLabel == null)
			{
				optionLabel =
					Resources.Messages.YouCanSelectAnItem;
			}

			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			string strHtmlFieldNameControl =
				string.Format("{0}Control", strHtmlFieldName);

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			// **************************************************
			string strValue = string.Empty;
			object objValue = oModelMetadata.Model;

			if ((objValue != null) &&
				(objValue.ToString() != "00000000-0000-0000-0000-000000000000"))
			{
				strValue = objValue.ToString();
			}
			// **************************************************

			// **************************************************
			bool blnReadOnly = false;

			if (oModelMetadata == null)
			{
				if (readOnly)
				{
					blnReadOnly = true;
				}
			}
			else
			{
				if ((readOnly) || (oModelMetadata.IsReadOnly))
				{
					blnReadOnly = true;
				}
			}
			// **************************************************

			System.Web.Mvc.SelectList oSelectList =
				html.ViewData[strHtmlFieldName] as System.Web.Mvc.SelectList;

			if (oSelectList == null)
			{
				throw (new System.Exception("Unexpected Error!"));
			}

			System.Collections.Generic.List<DropDownListItem> oList =
				new System.Collections.Generic.List<DropDownListItem>();

			foreach (object obj in oSelectList.Items)
			{
				object oId =
					obj.GetType().GetProperty(oSelectList.DataValueField).GetValue(obj);

				object oName =
					obj.GetType().GetProperty(oSelectList.DataTextField).GetValue(obj);

				oList.Add(new DropDownListItem(oId, oName));
			}

			string strSerializedObject =
				Newtonsoft.Json.JsonConvert.SerializeObject(oList);

			// توجه: دستور ذيل مناسب نيست
			//strResult +=
			//	string.Format("<input id='{0}' class='form-control' />", strHtmlFieldName);

			strResult +=
				string.Format("<input id='{0}' style='width: 100%' />", strHtmlFieldNameControl);

			if (oModelMetadata.IsRequired == false)
			{
				strResult +=
					string.Format("<input type='hidden' id='{0}' name='{0}' value='{1}' />",
					strHtmlFieldName, strValue);
			}
			else
			{
				string strLabelText =
					oModelMetadata.DisplayName ??
					oModelMetadata.PropertyName ??
					strHtmlFieldNameControl.Split('.').Last();

				string strErrorMessage =
					string.Format(Resources.Messages.RequiredValidation, strLabelText);

				strResult +=
					string.Format("<input type='hidden' id='{0}' name='{0}' value='{1}' data-val='true' data-val-required='{2}' />",
					strHtmlFieldName, strValue, strErrorMessage);
			}

			strResult += "<script>";
			strResult += "$(document).ready(function () {";

			strResult +=
				string.Format("var var{0}DataSource =", strHtmlFieldNameControl);

			strResult += "$.map(" + strSerializedObject + ", function (item, index) {";
			strResult += "	return ({ Id: item.Id, Name: item.Name });";
			strResult += "});";

			// نمی توان استفاده کرد string.Format توجه: از دستور
			strResult += "$('input#" + strHtmlFieldNameControl + "').kendoDropDownList({";

			if (blnReadOnly)
			{
				strResult += "enable: false,";
			}
			else
			{
				strResult += "enable: true,";
			}

			strResult += "ignoreCase: false,";

			if (searchable)
			{
				strResult += "filter: 'contains',";
			}

			if (strValue != string.Empty)
			{
				strResult +=
					string.Format("value: '{0}',", strValue);
			}

			strResult += "dataValueField: 'Id',";
			strResult += "dataTextField: 'Name',";

			if (string.IsNullOrWhiteSpace(optionLabel) == false)
			{
				//strResult +=
				//	string.Format("optionLabel: '{0}',", optionLabel);

				strResult += "optionLabel: {";
				strResult += "Id: '',";

				strResult +=
					string.Format("Name: '{0}',", optionLabel);

				strResult += "},";
			}

			strResult +=
				string.Format("dataSource: var{0}DataSource,", strHtmlFieldNameControl);

			strResult += "change: function(e) {";

			strResult += "var varId = this.value();";
			//strResult += "alert(varId);";

			strResult +=
				string.Format("$('input#{0}').val(varId);", strHtmlFieldName);

			strResult += "},";
			strResult += "});";
			strResult += "});";
			strResult += "</script>";

			return (html.Raw(strResult));
		}

		//public static System.Web.IHtmlString DtxAutoCompleteFor<TModel, TValue>
		//	(this System.Web.Mvc.HtmlHelper<TModel> html,
		//	System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
		//	System.Web.Mvc.ActionResult actionResult = null,
		//	System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
		//	string placeHolder = null, bool readOnly = false)
		//{
		//	// **************************************************
		//	System.Web.Mvc.IT4MVCActionResult oT4MVCActionResult =
		//		actionResult as System.Web.Mvc.IT4MVCActionResult;

		//	if (oT4MVCActionResult == null)
		//	{
		//		return (null);
		//	}

		//	string strAreaName = string.Empty;

		//	object objArea =
		//		oT4MVCActionResult.RouteValueDictionary["Area"];

		//	if ((objArea != null) &&
		//		(string.IsNullOrWhiteSpace(objArea.ToString()) == false))
		//	{
		//		strAreaName = objArea.ToString();
		//	}

		//	string strUrl =
		//		string.Format("/{0}", strAreaName);

		//	if (strUrl != "/")
		//	{
		//		strUrl += "/";
		//	}

		//	strUrl =
		//		string.Format("'{0}{1}/{2}'",
		//		strUrl, oT4MVCActionResult.Controller, oT4MVCActionResult.Action);
		//	// **************************************************

		//	// **************************************************
		//	if (htmlAttributes == null)
		//	{
		//		htmlAttributes =
		//			new System.Collections.Generic.Dictionary<string, object>();
		//	}

		//	string strHtmlFieldName =
		//		System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

		//	string strHtmlFieldNameControl =
		//		string.Format("{0}Control", strHtmlFieldName);

		//	System.Web.Mvc.ModelMetadata oModelMetadata =
		//		System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);
		//	// **************************************************

		//	// **************************************************
		//	string strValue = "''";
		//	object objValue = oModelMetadata.Model;

		//	if ((objValue != null) &&
		//		(objValue.ToString() != "00000000-0000-0000-0000-000000000000"))
		//	{
		//		strValue =
		//			string.Format("'{0}'", objValue);
		//	}
		//	// **************************************************

		//	// **************************************************
		//	string strEnable = "true";

		//	if (oModelMetadata == null)
		//	{
		//		if (readOnly)
		//		{
		//			strEnable = "false";
		//		}
		//	}
		//	else
		//	{
		//		if ((readOnly) || (oModelMetadata.IsReadOnly))
		//		{
		//			strEnable = "false";
		//		}
		//	}
		//	// **************************************************

		//	// **************************************************
		//	string strPlaceHolder = "''";

		//	if (string.IsNullOrWhiteSpace(placeHolder))
		//	{
		//		strPlaceHolder =
		//			string.Format("'{0}'",
		//			Resources.Messages.YouCanSelectAnItem);
		//	}
		//	else
		//	{
		//		strPlaceHolder =
		//			string.Format("'{0}'", placeHolder);
		//	}
		//	// **************************************************

		//	// **************************************************
		//	string strResult =
		//		string.Format("<input id='{0}' style='width: 100%' />",
		//		strHtmlFieldNameControl);

		//	if (oModelMetadata.IsRequired == false)
		//	{
		//		strResult +=
		//			string.Format("<input type='hidden' id='{0}' name='{0}' value='{1}' />",
		//			strHtmlFieldName, strValue);
		//	}
		//	else
		//	{
		//		string strLabelText =
		//			oModelMetadata.DisplayName ??
		//			oModelMetadata.PropertyName ??
		//			strHtmlFieldNameControl.Split('.').Last();

		//		string strErrorMessage =
		//			string.Format(Resources.Messages.RequiredValidationsErrorMessage, strLabelText);

		//		strResult +=
		//			string.Format("<input type='hidden' id='{0}' name='{0}' value='{1}' data-val='true' data-val-required='{2}' />",
		//			strHtmlFieldName, strValue, strErrorMessage);
		//	}
		//	// **************************************************

		//	// **************************************************
		//	string strFileName =
		//		"KendoUIComboBox.js";

		//	string strRootRelativePath =
		//		"~/App_Data/JavaScriptTemplates";

		//	string strPath =
		//		System.Web.HttpContext.Current.Server
		//		.MapPath(strRootRelativePath);

		//	string strPathName =
		//		string.Format("{0}\\{1}", strPath, strFileName);

		//	string strTemplate =
		//		Dtx.IO.File.Read(strPathName);
		//	// **************************************************

		//	// **************************************************
		//	strTemplate =
		//		strTemplate
		//		.Replace("[URL]", strUrl)
		//		.Replace("[VALUE]", strValue)
		//		.Replace("[ENABLE]", strEnable)
		//		.Replace("[DATA_VALUE_FIELD]", "'Id'")
		//		.Replace("[DATA_TEXT_FIELD]", "'DisplayName'")
		//		.Replace("[PLACE_HOLDER]", strPlaceHolder)
		//		.Replace("[INPUT_HIDDEN_NAME]", strHtmlFieldName)
		//		.Replace("[INPUT_TEXT_NAME]", strHtmlFieldNameControl)
		//		;

		//	strTemplate =
		//		string.Format("<script>{0}</script>", strTemplate);
		//	// **************************************************

		//	// **************************************************
		//	strResult += strTemplate;
		//	// **************************************************

		//	return (html.Raw(strResult));
		//}


		public static System.Web.Mvc.MvcHtmlString
			DtxValidationSummary(this System.Web.Mvc.HtmlHelper html,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null)
		{
			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			// TODO
			string strMessage = string.Empty;

			return (html.ValidationSummary(excludePropertyErrors: true, message: strMessage, htmlAttributes: htmlAttributes));
		}

		public static System.Web.Mvc.MvcHtmlString DtxLabelFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			int column = 0,
			bool ignoreFor = false,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null)
		{
			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			string strLabelText =
				oModelMetadata.DisplayName ??
				oModelMetadata.PropertyName ??
				strHtmlFieldName.Split('.').Last();

			if (string.IsNullOrEmpty(strLabelText))
			{
				return (System.Web.Mvc.MvcHtmlString.Empty);
			}

			System.Web.Mvc.TagBuilder oLabel =
				new System.Web.Mvc.TagBuilder("label");

			if (htmlAttributes != null)
			{
				oLabel.MergeAttributes(htmlAttributes);
			}

			if (ignoreFor == false)
			{
				oLabel.Attributes.Add("for",
					html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(strHtmlFieldName));
			}

			oLabel.SetInnerText(strLabelText);

			oLabel.AddCssClass("control-label");

			if ((column >= 1) && (column <= 12))
			{
				oLabel.AddCssClass("col-sm-" + column);
			}

			string strLabel =
				oLabel.ToString(System.Web.Mvc.TagRenderMode.Normal);

			return (System.Web.Mvc.MvcHtmlString.Create(strLabel));
		}

		public static System.Web.Mvc.MvcHtmlString DtxTextBoxFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
			bool displayPlaceHolder = true, bool readOnly = false)
		{
			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			if (oModelMetadata == null)
			{
				if (readOnly)
				{
					if (htmlAttributes.ContainsKey("readonly") == false)
					{
						htmlAttributes.Add("readonly", "read-only");
					}
				}
			}
			else
			{
				if ((readOnly) || (oModelMetadata.IsReadOnly))
				{
					if (htmlAttributes.ContainsKey("readonly") == false)
					{
						htmlAttributes.Add("readonly", "read-only");
					}
				}

				if ((htmlAttributes.ContainsKey("placeholder") == false) && (displayPlaceHolder))
				{
					string strLabelText =
						oModelMetadata.DisplayName ??
						oModelMetadata.PropertyName ??
						strHtmlFieldName.Split('.').Last();

					if (string.IsNullOrWhiteSpace(strLabelText) == false)
					{
						htmlAttributes.Add("placeholder", strLabelText);
					}
				}
			}

			// **************************************************
			string strExtendedClassName = "form-control";

			if (htmlAttributes.ContainsKey("class") == false)
			{
				htmlAttributes.Add("class", strExtendedClassName);
			}
			else
			{
				object objClass;

				bool blnResult =
					htmlAttributes.TryGetValue("class", out objClass);

				if ((blnResult) && (objClass != null))
				{
					htmlAttributes.Remove("class");

					htmlAttributes.Add
						("class", objClass.ToString() + " " + strExtendedClassName);
				}
			}
			// **************************************************

			// **************************************************
			System.Linq.Expressions.MemberExpression oMemberExpression =
				expression.Body as System.Linq.Expressions.MemberExpression;

			if (oMemberExpression != null)
			{
				int intMaximumLength = 0;

				System.ComponentModel.DataAnnotations.MaxLengthAttribute oMaxLengthAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.MaxLengthAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.MaxLengthAttribute;

				if (oMaxLengthAttribute != null)
				{
					intMaximumLength =
						oMaxLengthAttribute.Length;
				}
				else
				{
					System.ComponentModel.DataAnnotations.StringLengthAttribute oStringLengthAttribute =
						oMemberExpression.Member.GetCustomAttributes
						(typeof(System.ComponentModel.DataAnnotations.StringLengthAttribute), false)
						.FirstOrDefault() as System.ComponentModel.DataAnnotations.StringLengthAttribute;

					if (oStringLengthAttribute != null)
					{
						intMaximumLength =
							oStringLengthAttribute.MaximumLength;
					}
				}

				if ((htmlAttributes.ContainsKey("maxlength") == false) && (intMaximumLength > 0))
				{
					htmlAttributes.Add("maxlength", intMaximumLength);
				}
			}
			// **************************************************

			if ((htmlAttributes.ContainsKey("ng-model") == false) &&
				(htmlAttributes.ContainsKey("data-ng-model") == false))
			{
				htmlAttributes.Add("data-ng-model", strHtmlFieldName);
			}

			return (html.TextBoxFor(expression, htmlAttributes));
		}

		public static System.Web.Mvc.MvcHtmlString DtxPasswordFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
			bool displayPlaceHolder = true)
		{
			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			if (oModelMetadata != null)
			{
				if ((htmlAttributes.ContainsKey("placeholder") == false) && (displayPlaceHolder))
				{
					string strHtmlFieldName =
						System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

					string strLabelText =
						oModelMetadata.DisplayName ??
						oModelMetadata.PropertyName ??
						strHtmlFieldName.Split('.').Last();

					if (string.IsNullOrEmpty(strLabelText) == false)
					{
						htmlAttributes.Add("placeholder", strLabelText);
					}
				}
			}

			// **************************************************
			string strExtendedClassName = "form-control";

			if (htmlAttributes.ContainsKey("class") == false)
			{
				htmlAttributes.Add("class", strExtendedClassName);
			}
			else
			{
				object objClass;

				bool blnResult =
					htmlAttributes.TryGetValue("class", out objClass);

				if ((blnResult) && (objClass != null))
				{
					htmlAttributes.Remove("class");

					htmlAttributes.Add
						("class", objClass.ToString() + " " + strExtendedClassName);
				}
			}
			// **************************************************

			// **************************************************
			System.Linq.Expressions.MemberExpression oMemberExpression =
				expression.Body as System.Linq.Expressions.MemberExpression;

			if (oMemberExpression != null)
			{
				int intMaximumLength = 0;

				System.ComponentModel.DataAnnotations.MaxLengthAttribute oMaxLengthAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.MaxLengthAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.MaxLengthAttribute;

				if (oMaxLengthAttribute != null)
				{
					intMaximumLength = oMaxLengthAttribute.Length;
				}
				else
				{
					System.ComponentModel.DataAnnotations.StringLengthAttribute oStringLengthAttribute =
						oMemberExpression.Member.GetCustomAttributes
						(typeof(System.ComponentModel.DataAnnotations.StringLengthAttribute), false)
						.FirstOrDefault() as System.ComponentModel.DataAnnotations.StringLengthAttribute;

					if (oStringLengthAttribute != null)
					{
						intMaximumLength = oStringLengthAttribute.MaximumLength;
					}
				}

				if ((htmlAttributes.ContainsKey("maxlength") == false) && (intMaximumLength > 0))
				{
					htmlAttributes.Add("maxlength", intMaximumLength);
				}
			}
			// **************************************************

			return (html.PasswordFor(expression, htmlAttributes));
		}

		public static System.Web.Mvc.MvcHtmlString DtxTextAreaFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null, bool readOnly = false)
		{
			if (htmlAttributes == null)
			{
				htmlAttributes =
					new System.Collections.Generic.Dictionary<string, object>();
			}

			System.Web.Mvc.ModelMetadata oModelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			if (oModelMetadata == null)
			{
				if (readOnly)
				{
					if (htmlAttributes.ContainsKey("readonly") == false)
					{
						htmlAttributes.Add("readonly", "read-only");
					}
				}
			}
			else
			{
				if ((readOnly) || (oModelMetadata.IsReadOnly))
				{
					if (htmlAttributes.ContainsKey("readonly") == false)
					{
						htmlAttributes.Add("readonly", "read-only");
					}
				}

				if (htmlAttributes.ContainsKey("placeholder") == false)
				{
					string strHtmlFieldName =
						System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

					string strLabelText =
						oModelMetadata.DisplayName ??
						oModelMetadata.PropertyName ??
						strHtmlFieldName.Split('.').Last();

					if (string.IsNullOrEmpty(strLabelText) == false)
					{
						htmlAttributes.Add("placeholder", strLabelText);
					}
				}
			}

			// **************************************************
			string strExtendedClassName = "form-control";

			if (htmlAttributes.ContainsKey("class") == false)
			{
				htmlAttributes.Add("class", strExtendedClassName);
			}
			else
			{
				object objClass;
				bool blnResult =
					htmlAttributes.TryGetValue("class", out objClass);

				if ((blnResult) && (objClass != null))
				{
					htmlAttributes.Remove("class");
					htmlAttributes.Add
						("class", objClass.ToString() + " " + strExtendedClassName);
				}
			}
			// **************************************************

			System.Linq.Expressions.MemberExpression oMemberExpression =
				expression.Body as System.Linq.Expressions.MemberExpression;

			if (oMemberExpression != null)
			{
				System.ComponentModel.DataAnnotations.StringLengthAttribute oStringLengthAttribute =
					oMemberExpression.Member.GetCustomAttributes
					(typeof(System.ComponentModel.DataAnnotations.StringLengthAttribute), false)
					.FirstOrDefault() as System.ComponentModel.DataAnnotations.StringLengthAttribute;

				if (oStringLengthAttribute != null)
				{
					if (htmlAttributes.ContainsKey("maxlength") == false)
					{
						htmlAttributes.Add("maxlength", oStringLengthAttribute.MaximumLength);
					}
				}
			}

			return (html.TextAreaFor(expression, htmlAttributes));
		}

		//public static System.Web.Mvc.MvcHtmlString DtxDropDownListFor<TModel, TValue>
		//	(this System.Web.Mvc.HtmlHelper<TModel> html,
		//	System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
		//	System.Collections.Generic.IDictionary<string, object> htmlAttributes = null,
		//	string optionLabel = null, bool readOnly = false)
		//{
		//	if (htmlAttributes == null)
		//	{
		//		htmlAttributes =
		//			new System.Collections.Generic.Dictionary<string, object>();
		//	}

		//	System.Web.Mvc.ModelMetadata oModelMetadata =
		//		System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

		//	if (oModelMetadata == null)
		//	{
		//		if (readOnly)
		//		{
		//			if (htmlAttributes.ContainsKey("readonly") == false)
		//			{
		//				htmlAttributes.Add("readonly", "read-only");
		//			}
		//		}
		//	}
		//	else
		//	{
		//		if ((readOnly) || (oModelMetadata.IsReadOnly))
		//		{
		//			if (htmlAttributes.ContainsKey("readonly") == false)
		//			{
		//				htmlAttributes.Add("readonly", "read-only");
		//			}
		//		}

		//		if (htmlAttributes.ContainsKey("placeholder") == false)
		//		{
		//			string strHtmlFieldName =
		//				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

		//			string strLabelText =
		//				oModelMetadata.DisplayName ??
		//				oModelMetadata.PropertyName ??
		//				strHtmlFieldName.Split('.').Last();

		//			if (string.IsNullOrEmpty(strLabelText) == false)
		//			{
		//				htmlAttributes.Add("placeholder", strLabelText);
		//			}
		//		}
		//	}

		//	// **************************************************
		//	string strExtendedClassName = "form-control";

		//	if (htmlAttributes.ContainsKey("class") == false)
		//	{
		//		htmlAttributes.Add("class", strExtendedClassName);
		//	}
		//	else
		//	{
		//		object objClass;
		//		bool blnResult =
		//			htmlAttributes.TryGetValue("class", out objClass);

		//		if ((blnResult) && (objClass != null))
		//		{
		//			htmlAttributes.Remove("class");
		//			htmlAttributes.Add
		//				("class", objClass.ToString() + " " + strExtendedClassName);
		//		}
		//	}
		//	// **************************************************

		//	if (string.IsNullOrWhiteSpace(optionLabel))
		//	{
		//		return (html.DropDownListFor(expression, null, htmlAttributes));
		//	}
		//	else
		//	{
		//		return (html.DropDownListFor(expression, null, optionLabel, htmlAttributes));
		//	}
		//}

		public static System.Web.IHtmlString DtxSimpleSubmit
			(this System.Web.Mvc.HtmlHelper helper, string caption, string id = null)
		{
			string strResult = string.Empty;

			if (string.IsNullOrEmpty(id))
			{
				strResult =
					string.Format("<button type='submit' class='btn btn-primary btn-icon btn-green icon-alarmclock'>{0}</button>", caption);
			}
			else
			{
				strResult =
					string.Format("<button type='submit' id='{0}' name='{0}' class='btn btn-primary btn-icon btn-green icon-alarmclock'>{1}</button>", id, caption);
			}

			return (helper.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxSimpleButton
			(this System.Web.Mvc.HtmlHelper helper, string id, string caption)
		{
			string strResult = string.Empty;

			if (string.IsNullOrEmpty(id))
			{
				strResult =
					string.Format("<button type='button' class='btn btn-primary btn-icon btn-green icon-alarmclock'>{0}</button>", caption);
			}
			else
			{
				strResult =
					string.Format("<button type='button' id='{0}' name='{0}' class='btn btn-primary btn-icon btn-green icon-alarmclock'>{1}</button>", id, caption);
			}

			return (helper.Raw(strResult));
		}

		public static System.Web.IHtmlString DtxSimpleReset
			(this System.Web.Mvc.HtmlHelper helper, string id = null, string caption = null)
		{
			if (string.IsNullOrWhiteSpace(id))
			{
				id = "btnReset";
			}

			if (string.IsNullOrWhiteSpace(caption))
			{
				caption =
					Resources.Buttons.Reset;
			}

			string strResult =
					string.Format("<button type='reset' id='{0}' name='{0}' class='btn btn-default'>{1}</button>",
					id, caption);

			return (helper.Raw(strResult));
		}

		public static System.Web.IHtmlString DisplayDateTime
			(this System.Web.Mvc.HtmlHelper helper, System.DateTime? dateTime)
		{
			return (DisplayDateTime(helper, dateTime, false));
		}

		public static System.Web.IHtmlString DisplayDateTime
			(this System.Web.Mvc.HtmlHelper helper, System.DateTime? dateTime, bool displayTime)
		{
			string strResult = "-----";

			if (dateTime.HasValue)
			{
				strResult =
					Dtx.Calendar.Utility.DisplayDateTime
					(dateTime.Value, displayTime, strResult);
			}

			return (helper.Raw(strResult));
		}

		public static System.Web.IHtmlString DisplayDateTime
			(this System.Web.Mvc.HtmlHelper helper, Models.ComplexTypes.CustomDateTime customDateTime)
		{
			return (DisplayDateTime(helper, customDateTime, false));
		}

		public static System.Web.IHtmlString DisplayDateTime
			(this System.Web.Mvc.HtmlHelper helper, Models.ComplexTypes.CustomDateTime customDateTime, bool displayTime)
		{
			string strResult = "-----";

			if (customDateTime != null)
			{
				if (customDateTime.Value.HasValue)
				{
					strResult =
						Dtx.Calendar.Utility.DisplayDateTime
						(customDateTime.Value.Value, displayTime, strResult);
				}
			}

			return (helper.Raw(strResult));
		}

		public static System.Web.Mvc.MvcHtmlString HiddenForDateTime<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression)
			where TModel : class
		{
			var varMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression
				(expression, htmlHelper.ViewData);

			//var varMetadata =
			//	System.Web.Http.Metadata.ModelMetadata.FromLambdaExpression
			//	(expression, htmlHelper.ViewData);

			var varValue = varMetadata.Model;

			return (htmlHelper.HiddenForDateTime(expression, varValue));
		}

		public static System.Web.Mvc.MvcHtmlString HiddenForDateTime<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, object value)
			where TModel : class
		{
			string strHtmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			string strFullName =
				htmlHelper.ViewContext.ViewData.TemplateInfo
				.GetFullHtmlFieldName(strHtmlFieldName);

			var strTag =
				new System.Web.Mvc.TagBuilder("input");

			strTag.GenerateId(strFullName);

			strTag.Attributes.Add("type", "hidden");
			strTag.Attributes.Add("name", strFullName);

			string strValue = string.Empty;

			if (value != null)
			{
				System.DateTime dtmValue =
					(System.DateTime)value;

				strValue = dtmValue.ToString("yyyy/MM/dd HH:mm:ss");
			}

			strTag.Attributes.Add("value", strValue);

			return (new System.Web.Mvc.MvcHtmlString(strTag.ToString()));
		}

		public static System.Web.IHtmlString DtxTimeDifference
			(this System.Web.Mvc.HtmlHelper helper, System.DateTime dateTime)
		{
			string strResult = string.Empty;

			System.DateTime dtmNow = System.DateTime.Now;

			if (dtmNow <= dateTime)
			{
				return (helper.Raw(string.Empty));
			}

			System.TimeSpan dtmDifference =
				dtmNow - dateTime;

			if (dtmDifference < new System.TimeSpan(0, 1, 0))
			{
				strResult =
					string.Format("{0} ثانيه قبل", dtmDifference.Seconds);

				return (helper.Raw(strResult));
			}

			if (dtmDifference < new System.TimeSpan(1, 0, 0))
			{
				strResult =
					string.Format("{0} دقيقه قبل", dtmDifference.Minutes);

				return (helper.Raw(strResult));
			}

			if (dtmDifference < new System.TimeSpan(1, 0, 0, 0))
			{
				strResult =
					string.Format("{0} ساعت و {1} دقيقه قبل", dtmDifference.Hours, dtmDifference.Minutes);

				return (helper.Raw(strResult));
			}

			if (dtmDifference < new System.TimeSpan(2, 0, 0, 0))
			{
				strResult = "ديروز";

				return (helper.Raw(strResult));
			}

			if (dtmDifference < new System.TimeSpan(7, 0, 0, 0))
			{
				switch (dateTime.DayOfWeek)
				{
					case System.DayOfWeek.Saturday:
					{
						strResult = "شنبه";
						break;
					}

					case System.DayOfWeek.Sunday:
					{
						strResult = "يکشنبه";
						break;
					}

					case System.DayOfWeek.Monday:
					{
						strResult = "دوشنبه";
						break;
					}

					case System.DayOfWeek.Tuesday:
					{
						strResult = "سه شنبه";
						break;
					}

					case System.DayOfWeek.Wednesday:
					{
						strResult = "چهارشنبه";
						break;
					}

					case System.DayOfWeek.Thursday:
					{
						strResult = "پنجشنبه";
						break;
					}

					case System.DayOfWeek.Friday:
					{
						strResult = "جمعه";
						break;
					}
				}

				return (helper.Raw(strResult));
			}

			System.Globalization.PersianCalendar oPersianCalendar =
				new System.Globalization.PersianCalendar();

			int intMonth = oPersianCalendar.GetMonth(dateTime);
			int intDay = oPersianCalendar.GetDayOfMonth(dateTime);

			string strMonth = string.Empty;

			switch (intMonth)
			{
				case 1:
				{
					strMonth = "فروردين";
					break;
				}

				case 2:
				{
					strMonth = "ارديبهشت";
					break;
				}

				case 3:
				{
					strMonth = "خرداد";
					break;
				}

				case 4:
				{
					strMonth = "تير";
					break;
				}

				case 5:
				{
					strMonth = "مرداد";
					break;
				}

				case 6:
				{
					strMonth = "شهريور";
					break;
				}

				case 7:
				{
					strMonth = "مهر";
					break;
				}

				case 8:
				{
					strMonth = "آبان";
					break;
				}

				case 9:
				{
					strMonth = "آذر";
					break;
				}

				case 10:
				{
					strMonth = "دی";
					break;
				}

				case 11:
				{
					strMonth = "بهمن";
					break;
				}

				case 12:
				{
					strMonth = "اسفند";
					break;
				}
			}

			strResult =
				string.Format("{0} {1}", intDay, strMonth);

			return (helper.Raw(strResult));
		}
	}
}
