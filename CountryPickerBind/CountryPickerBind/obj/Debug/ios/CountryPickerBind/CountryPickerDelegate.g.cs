//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace CountryPickerBind {
	[Protocol (Name = "CountryPickerDelegate", WrapperType = typeof (CountryPickerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidSelectCountryWithName", Selector = "countryPicker:didSelectCountryWithName:code:", ParameterType = new Type [] { typeof (CountryPickerBind.CountryPicker), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public interface ICountryPickerDelegate : INativeObject, IDisposable, 
		UIKit.IUIPickerViewDelegate
		
	{
		[CompilerGenerated]
		[Export ("countryPicker:didSelectCountryWithName:code:")]
		[Preserve (Conditional = true)]
		void DidSelectCountryWithName (CountryPicker picker, string name, string code);
		
	}
	
	internal sealed class CountryPickerDelegateWrapper : BaseWrapper, ICountryPickerDelegate {
		[Preserve (Conditional = true)]
		public CountryPickerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("countryPicker:didSelectCountryWithName:code:")]
		[CompilerGenerated]
		public void DidSelectCountryWithName (CountryPicker picker, string name, string code)
		{
			if (picker == null)
				throw new ArgumentNullException ("picker");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (code == null)
				throw new ArgumentNullException ("code");
			var nsname = NSString.CreateNative (name);
			var nscode = NSString.CreateNative (code);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("countryPicker:didSelectCountryWithName:code:"), picker.Handle, nsname, nscode);
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nscode);
			
		}
		
	}
}
namespace CountryPickerBind {
	[Protocol]
	[Register("CountryPickerDelegate", false)]
	[Model]
	public unsafe abstract partial class CountryPickerDelegate : NSObject, ICountryPickerDelegate, global::UIKit.IUIPickerViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CountryPickerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CountryPickerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CountryPickerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("countryPicker:didSelectCountryWithName:code:")]
		[CompilerGenerated]
		public abstract void DidSelectCountryWithName (CountryPicker picker, string name, string code);
	} /* class CountryPickerDelegate */
}
