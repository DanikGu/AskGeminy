using ManagedCommon;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Wox.Infrastructure;
using Wox.Plugin;
using Wox.Plugin.Logger;
using BrowserInfo = Wox.Plugin.Common.DefaultBrowserInfo;

namespace Community.PowerToys.Run.Plugin.AskGem
{
	/// <summary>
	/// Main class of this plugin that implement all used interfaces.
	/// </summary>
	public class Main : IPlugin, IContextMenu, IDisposable
	{
		private Action onPluginError;
		/// <summary>
		/// ID of the plugin.
		/// </summary>
		public static string PluginID => "55597B78746847AD85E3F12A9766229B";

		/// <summary>
		/// Name of the plugin.
		/// </summary>
		public string Name => "AskGem";

		/// <summary>
		/// Description of the plugin.
		/// </summary>
		public string Description => "Open Geminy with query or mic started";
		private static readonly CompositeFormat InBrowserName = System.Text.CompositeFormat.Parse("In the default browser");
		private static readonly CompositeFormat Open = System.Text.CompositeFormat.Parse("Prompt ChatGPT with {0}");
		private static readonly CompositeFormat SearhFailed = System.Text.CompositeFormat.Parse("Failed to open {0}.");

		private PluginInitContext Context { get; set; }

		private string IconPath { get; set; }

		private bool Disposed { get; set; }

		/// <summary>
		/// Return a filtered list, based on the given query.
		/// </summary>
		/// <param name="query">The query to filter the list.</param>
		/// <returns>A filtered list, can be empty when nothing was found.</returns>
		public List<Result> Query(Query query)
		{
			var search = query.Search;

			return
			[
				new Result
				{
					QueryTextDisplay = search,
					IcoPath = IconPath,
					Title = "gem: " + search,
					SubTitle = string.Format(CultureInfo.CurrentCulture, InBrowserName, BrowserInfo.Name ?? BrowserInfo.MSEdgeName),
					ToolTipData = new ToolTipData("Ask Geminy", "ask something ..."),
					Action = _ =>
					{
						var arguments = new StringBuilder("https://gemini.google.com/app");
						if (string.IsNullOrEmpty(search))
						{
							 arguments.Append("?micautoplay=true");
							 if (!Helper.OpenCommandInShell(BrowserInfo.Path, BrowserInfo.ArgumentsPattern, arguments.ToString()))
							 {
								 onPluginError();
								 return false;
							 }
						}
						else
						{
							arguments.AppendFormat("?customquery={0}", query);
							if (!Helper.OpenCommandInShell(BrowserInfo.Path, BrowserInfo.ArgumentsPattern, arguments.ToString()))
							{
								onPluginError();
								return false;
							}
						}

						return true;
					},
					ContextData = search,
				}
			];
		}

		/// <summary>
		/// Initialize the plugin with the given <see cref="PluginInitContext"/>.
		/// </summary>
		/// <param name="context">The <see cref="PluginInitContext"/> for this plugin.</param>
		public void Init(PluginInitContext context)
		{
			Context = context ?? throw new ArgumentNullException(nameof(context));
			Context.API.ThemeChanged += OnThemeChanged;
			UpdateIconPath(Context.API.GetCurrentTheme());
			onPluginError = () =>
			{
				string errorMsgString = string.Format(CultureInfo.CurrentCulture, SearhFailed, BrowserInfo.Name ?? BrowserInfo.MSEdgeName);

				Log.Error(errorMsgString, this.GetType());
			};
		}

		/// <summary>
		/// Return a list context menu entries for a given <see cref="Result"/> (shown at the right side of the result).
		/// </summary>
		/// <param name="selectedResult">The <see cref="Result"/> for the list with context menu entries.</param>
		/// <returns>A list context menu entries.</returns>
		public List<ContextMenuResult> LoadContextMenus(Result selectedResult)
		{
			return [];
		}

		/// <inheritdoc/>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Wrapper method for <see cref="Dispose()"/> that dispose additional objects and events form the plugin itself.
		/// </summary>
		/// <param name="disposing">Indicate that the plugin is disposed.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (Disposed || !disposing)
			{
				return;
			}

			if (Context?.API != null)
			{
				Context.API.ThemeChanged -= OnThemeChanged;
			}

			Disposed = true;
		}

		private void UpdateIconPath(Theme theme) => IconPath = theme == Theme.Light || theme == Theme.HighContrastWhite ? "Images/askgem.light.png" : "Images/askgem.dark.png";

		private void OnThemeChanged(Theme currentTheme, Theme newTheme) => UpdateIconPath(newTheme);
	}
}
