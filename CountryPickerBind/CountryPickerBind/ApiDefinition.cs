using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace CountryPickerBind
{
	// @protocol CountryPickerDelegate <UIPickerViewDelegate>
    [BaseType(typeof(NSObject))]
	[Protocol, Model]
	interface CountryPickerDelegate : IUIPickerViewDelegate
	{
		// @required -(void)countryPicker:(CountryPicker *)picker didSelectCountryWithName:(NSString *)name code:(NSString *)code;
		[Abstract]
		[Export("countryPicker:didSelectCountryWithName:code:")]
		void DidSelectCountryWithName(CountryPicker picker, string name, string code);
	}

	// @interface CountryPicker : UIPickerView
	[BaseType(typeof(UIPickerView))]
	interface CountryPicker
	{
        // +(NSArray<NSString *> *)countryNames;
        [Static]
        [Export("countryNames")]
        string[] CountryNames();

        // +(NSArray<NSString *> *)countryCodes;
        [Static]
        [Export("countryCodes")]
        string[] CountryCodes();

        // +(NSDictionary<NSString *,NSString *> *)countryNamesByCode;
        [Static]
        [Export("countryNamesByCode")]
        NSDictionary<NSString, NSString> CountryNamesByCode();

        // +(NSDictionary<NSString *,NSString *> *)countryCodesByName;
        [Static]
        [Export("countryCodesByName")]
        NSDictionary<NSString, NSString> CountryCodesByName();

		[Wrap("WeakDelegate")]
		CountryPickerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<CountryPickerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * selectedCountryName;
		[Export("selectedCountryName")]
		string SelectedCountryName { get; set; }

		// @property (copy, nonatomic) NSString * selectedCountryCode;
		[Export("selectedCountryCode")]
		string SelectedCountryCode { get; set; }

		// @property (copy, nonatomic) NSLocale * selectedLocale;
		[Export("selectedLocale", ArgumentSemantic.Copy)]
		NSLocale SelectedLocale { get; set; }

		// @property (copy, nonatomic) UIFont * labelFont;
		[Export("labelFont", ArgumentSemantic.Copy)]
		UIFont LabelFont { get; set; }

		// -(void)setSelectedCountryCode:(NSString *)countryCode animated:(BOOL)animated;
		[Export("setSelectedCountryCode:animated:")]
		void SetSelectedCountryCode(string countryCode, bool animated);

		// -(void)setSelectedCountryName:(NSString *)countryName animated:(BOOL)animated;
		[Export("setSelectedCountryName:animated:")]
		void SetSelectedCountryName(string countryName, bool animated);

		// -(void)setSelectedLocale:(NSLocale *)locale animated:(BOOL)animated;
		[Export("setSelectedLocale:animated:")]
		void SetSelectedLocale(NSLocale locale, bool animated);
	}
}
