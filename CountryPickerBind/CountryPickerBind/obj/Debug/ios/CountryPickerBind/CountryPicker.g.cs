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
	[Register("CountryPicker", true)]
	public unsafe partial class CountryPicker : global::UIKit.UIPickerView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CountryPicker");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CountryPicker () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CountryPicker (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CountryPicker (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CountryPicker (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("countryCodes")]
		[CompilerGenerated]
		public static string[] CountryCodes ()
		{
			return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("countryCodes")));
		}
		
		[Export ("countryCodesByName")]
		[CompilerGenerated]
		public static NSDictionary<NSString, NSString> CountryCodesByName ()
		{
			return  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("countryCodesByName")));
		}
		
		[Export ("countryNames")]
		[CompilerGenerated]
		public static string[] CountryNames ()
		{
			return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("countryNames")));
		}
		
		[Export ("countryNamesByCode")]
		[CompilerGenerated]
		public static NSDictionary<NSString, NSString> CountryNamesByCode ()
		{
			return  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("countryNamesByCode")));
		}
		
		[Export ("setSelectedCountryCode:animated:")]
		[CompilerGenerated]
		public virtual void SetSelectedCountryCode (string countryCode, bool animated)
		{
			if (countryCode == null)
				throw new ArgumentNullException ("countryCode");
			var nscountryCode = NSString.CreateNative (countryCode);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setSelectedCountryCode:animated:"), nscountryCode, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setSelectedCountryCode:animated:"), nscountryCode, animated);
			}
			NSString.ReleaseNative (nscountryCode);
			
		}
		
		[Export ("setSelectedCountryName:animated:")]
		[CompilerGenerated]
		public virtual void SetSelectedCountryName (string countryName, bool animated)
		{
			if (countryName == null)
				throw new ArgumentNullException ("countryName");
			var nscountryName = NSString.CreateNative (countryName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setSelectedCountryName:animated:"), nscountryName, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setSelectedCountryName:animated:"), nscountryName, animated);
			}
			NSString.ReleaseNative (nscountryName);
			
		}
		
		[Export ("setSelectedLocale:animated:")]
		[CompilerGenerated]
		public virtual void SetSelectedLocale (NSLocale locale, bool animated)
		{
			if (locale == null)
				throw new ArgumentNullException ("locale");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setSelectedLocale:animated:"), locale.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setSelectedLocale:animated:"), locale.Handle, animated);
			}
		}
		
		[CompilerGenerated]
		public CountryPickerDelegate Delegate {
			get {
				return WeakDelegate as CountryPickerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIFont LabelFont {
			[Export ("labelFont", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelFont")));
				}
				return ret;
			}
			
			[Export ("setLabelFont:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabelFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelFont:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SelectedCountryCode {
			[Export ("selectedCountryCode")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedCountryCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedCountryCode")));
				}
			}
			
			[Export ("setSelectedCountryCode:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedCountryCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedCountryCode:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string SelectedCountryName {
			[Export ("selectedCountryName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedCountryName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedCountryName")));
				}
			}
			
			[Export ("setSelectedCountryName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedCountryName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedCountryName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSLocale SelectedLocale {
			[Export ("selectedLocale", ArgumentSemantic.Copy)]
			get {
				NSLocale ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLocale> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedLocale")));
				} else {
					ret =  Runtime.GetNSObject<NSLocale> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedLocale")));
				}
				return ret;
			}
			
			[Export ("setSelectedLocale:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedLocale:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedLocale:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class CountryPickerAppearance : global::UIKit.UIPickerView.UIPickerViewAppearance {
			protected internal CountryPickerAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new CountryPickerAppearance Appearance {
			get { return new CountryPickerAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new CountryPickerAppearance GetAppearance<T> () where T: CountryPicker {
			return new CountryPickerAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new CountryPickerAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new CountryPickerAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new CountryPickerAppearance GetAppearance (UITraitCollection traits) {
			return new CountryPickerAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new CountryPickerAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new CountryPickerAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new CountryPickerAppearance GetAppearance<T> (UITraitCollection traits) where T: CountryPicker {
			return new CountryPickerAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new CountryPickerAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: CountryPicker{
			return new CountryPickerAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class CountryPicker */
}
