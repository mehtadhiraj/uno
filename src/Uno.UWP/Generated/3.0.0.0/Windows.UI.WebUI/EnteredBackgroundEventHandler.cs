#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	public delegate void EnteredBackgroundEventHandler(object @sender, global::Windows.ApplicationModel.IEnteredBackgroundEventArgs @e);
	#endif
}
