// ****************************************************************************
// <copyright file="AssemblyInfo.cs" company="GalaSoft Laurent Bugnion">
// Copyright © GalaSoft Laurent Bugnion 2009-2016
// </copyright>
// ****************************************************************************
// <author>Laurent Bugnion</author>
// <email>laurent@galasoft.ch</email>
// <date>3.11.2009</date>
// <project>GalaSoft.MvvmLight.Platform</project>
// <web>http://www.mvvmlight.net</web>
// <license>
// See license.txt in this project or http://www.galasoft.ch/license_MIT.txt
// </license>
// ****************************************************************************

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyDescription(".NET Standard 1.0. Platform components to implement Model-View-ViewModel applications in WPF, Windows Store, Windows Phone, Silverlight and Xamarin. These are needed because of technical constraints with portable class libraries .")]
[assembly: AssemblyCopyright("Copyright © GalaSoft Laurent Bugnion 2009-2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if !NETFX_CORE
#if !XAMARIN
#if !WINDOWS_PHONE
[assembly: System.Windows.Markup.XmlnsDefinition("http://www.galasoft.ch/mvvmlight", "GalaSoft.MvvmLight.Command")]
#endif
#endif
#endif

[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en-US")]

#if NET46
[assembly: CLSCompliant(true)]
#endif
