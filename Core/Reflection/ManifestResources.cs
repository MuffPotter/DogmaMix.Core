﻿
//----------------------------------------------------------------------------------------------------
// <auto-generated> 
//     This code was generated by a T4 template: ManifestResources.tt
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// </auto-generated> 
//----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DogmaMix.Core.Extensions;

namespace DogmaMix.Core
{
    /// <summary>
    /// Provides properties and methods for retrieving manifest resources 
    /// (also known as embedded resources) from the current assembly.
    /// These properties and methods provide compile-time checking and IntelliSense for the
    /// manifest resource names, which is preferable over the standard approach of supplying
    /// hardcoded strings to the <see cref="Assembly.GetManifestResourceStream(string)"/> method.
    /// </summary>
    /// <remarks>
    /// <para>
    /// MSBuild has an internal set of rules for constructing resource names, involving escaped 
    /// representations of the project default namespace, resource relative directory path, and 
    /// resource filename. Rather than reverse-engineer these naming rules,
    /// the template that generated this class introduces &lt;LogicalName&gt; elements in the 
    /// project file to substitute simpler explicit names instead.
    /// </para>
    /// <list type="bullet">
    /// <listheader>References</listheader>
    /// <item><see href="http://stackoverflow.com/a/3314213/1149773">How to read embedded resource text file</see> (answer), <i>Stack Overflow</i></item>
    /// <item><see href="https://social.msdn.microsoft.com/Forums/vstudio/en-US/632d6914-8c90-450e-8ea0-fa60d2c3b6b6/">Manifest name for Embedded resources</see>, <i>MSDN Forums</i></item>
    /// </list>
    /// </remarks>
    internal static class ManifestResources
    {
        /// <summary>
        /// Loads the manifest resource "xhtml11-flat.dtd" from this assembly.
        /// </summary>
        /// <returns>
        /// The manifest resource.
        /// The caller is responsible for disposing of this stream when done with it.
        /// </returns>
        public static Stream GetXhtml11FlatDtd() => GetManifestResourceStream(@"xhtml11-flat.dtd");
                
        /// <summary>
        /// Gets a byte array for the manifest resource "xhtml11-flat.dtd" from this assembly.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the resource represents a text document, then its byte array might start with a
        /// <see href="https://en.wikipedia.org/wiki/Byte_order_mark">byte order mark</see> (BOM).
        /// To acquire a <see cref="string"/> representation of a text resource, read the 
        /// <see cref="Stream"/> returned by the <see cref="GetXhtml11FlatDtd()"/> 
        /// method using a <see cref="StreamReader"/> instead, which automatically removes the BOM.
        /// </para>
        /// </remarks>
        public static byte[] Xhtml11FlatDtdBytes =>
            GetManifestResourceBytes(@"xhtml11-flat.dtd");

        /// <summary>
        /// Loads the manifest resource "Xhtml5Entities.dtd" from this assembly.
        /// </summary>
        /// <returns>
        /// The manifest resource.
        /// The caller is responsible for disposing of this stream when done with it.
        /// </returns>
        public static Stream GetXhtml5EntitiesDtd() => GetManifestResourceStream(@"Xhtml5Entities.dtd");
                
        /// <summary>
        /// Gets a byte array for the manifest resource "Xhtml5Entities.dtd" from this assembly.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the resource represents a text document, then its byte array might start with a
        /// <see href="https://en.wikipedia.org/wiki/Byte_order_mark">byte order mark</see> (BOM).
        /// To acquire a <see cref="string"/> representation of a text resource, read the 
        /// <see cref="Stream"/> returned by the <see cref="GetXhtml5EntitiesDtd()"/> 
        /// method using a <see cref="StreamReader"/> instead, which automatically removes the BOM.
        /// </para>
        /// </remarks>
        public static byte[] Xhtml5EntitiesDtdBytes =>
            GetManifestResourceBytes(@"Xhtml5Entities.dtd");

        private static Stream GetManifestResourceStream(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceStream = assembly.GetManifestResourceStream(resourceName);            
            if (resourceStream == null)
                throw new InvalidOperationException($"Manifest resource \"{resourceName}\" was not found in the assembly.");
                
            return resourceStream;
        }

        private static byte[] GetManifestResourceBytes(string resourceName)
        {
            using (var resourceStream = GetManifestResourceStream(resourceName))
                return resourceStream.ReadToEnd();
        }
    }
}