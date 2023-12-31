﻿// Copyright 2020-2022 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace GLTFast.Schema {

    /// <summary>
    /// Extension for optical transparency (transmission)
    /// <seealso href="https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Khronos/KHR_materials_transmission"/>
    /// </summary>
    [System.Serializable]
    public class Transmission {

        /// <summary>
        /// The base fraction of light that is transmitted through the surface.
        /// </summary>
        public float transmissionFactor = 0;
        
        /// <summary>
        /// A texture that defines the transmission fraction of the surface,
        /// stored in the R channel. This will be multiplied by
        /// transmissionFactor.
        /// </summary>
        public TextureInfo transmissionTexture = null;

        internal void GltfSerialize(JsonWriter writer) {
            writer.AddObject();
            writer.Close();
            throw new System.NotImplementedException($"GltfSerialize missing on {GetType()}");
        }
    }
}