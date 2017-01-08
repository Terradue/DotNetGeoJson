﻿//
//  LinkedCRS.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

using System;
using System.Collections.Generic;

namespace Terradue.GeoJson.CoordinateReferenceSystem
{
  /// <summary>
    /// Defines the <see cref="http://geojson.org/geojson-spec.html#linked-crs">Linked CRS type</see>.
    /// </summary>
    public class LinkedCRS : CRSBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedCRS"/> class.
        /// </summary>
        /// <param name="href">The mandatory <see cref="http://geojson.org/geojson-spec.html#linked-crs">href</see> member must be a dereferenceable URI.</param>
        /// <param name="type">The optional type member will be put in the properties Dictionary as specified in the <see cref="http://geojson.org/geojson-spec.html#linked-crs">GeoJSON spec</see>.</param>
        public LinkedCRS(string href, string type = "")
        {
            if (href == null)
            {
                throw new ArgumentNullException("href");
            }

            if (string.IsNullOrWhiteSpace(href))
            {
                throw new ArgumentOutOfRangeException("href", "May not be empty");
            }

            Properties = new Dictionary<string, object> { { "href", href } };

            if (!string.IsNullOrWhiteSpace(type))
            {
                Properties.Add("type", type);
            }

            Type = CRSType.Link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedCRS"/> class.
        /// </summary>
        /// <param name="href">The mandatory <see cref="http://geojson.org/geojson-spec.html#linked-crs">href</see> member must be a dereferenceable URI.</param>
        /// <param name="type">The optional type member will be put in the properties Dictionary as specified in the <see cref="http://geojson.org/geojson-spec.html#linked-crs">GeoJSON spec</see>.</param>
        public LinkedCRS(Uri href, string type = "") : this(href.ToString(), type)
        {
        }
    }
}
