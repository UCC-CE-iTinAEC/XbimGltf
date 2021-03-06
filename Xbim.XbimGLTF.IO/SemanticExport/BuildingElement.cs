﻿using System;
using System.Collections.Generic;
using Xbim.Common.Geometry;
using Xbim.Ifc4.Interfaces;

namespace Xbim.GLTF.SemanticExport
{
    public class BuildingElement : JsonIfcObject
    {
        /// <summary>
        /// index in systems array 
        /// </summary>
        public int ifcSystemIndex = -1; // point 2

        /// <summary>
        /// index in storey array 
        /// </summary>
        public int ifcStoreyIndex = -1; // ": index in the storeys array // for point 3

        /// <summary>
        /// index in space array 
        /// </summary>
        public int ifcSpaceIndex = -1; // ": index in the spaces array // for point 4

        // todo: restore
        // public string gltfRepresentationGUID; // ": "323ss-as32342-sdasa2332-aasa",

        // todo: restore
        // public XbimMatrix3D gltfRepresentationPlacementMatrix; //": 4x4 matrix,
    }
}