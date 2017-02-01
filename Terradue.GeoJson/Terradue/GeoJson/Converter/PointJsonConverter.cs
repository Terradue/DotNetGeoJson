//
//  MultiPolygonConverter.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2015 Terradue
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
using System;
using Newtonsoft.Json;
using Terradue.GeoJson.Geometry;
using Newtonsoft.Json.Linq;

namespace Terradue.GeoJson {
    public class PointJsonConverter : JsonConverter {
        public PointJsonConverter() {
        }

        #region implemented abstract members of JsonConverter

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var o = serializer.Deserialize<JArray>(reader);

            if (o.Count < 2 || o.Count > 3)
                throw new InvalidFormatException("invalid GeoJson representation: point members are not 2 or 3 :" + 0.ToString());

            string z = (o.Count > 2 ? o[2].ToString() : null);
            Point point = new Point(new GeographicPosition(o[1].ToString(), o[0].ToString(), z));

            return point;
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(Point);
        }

        #endregion
    }
}

