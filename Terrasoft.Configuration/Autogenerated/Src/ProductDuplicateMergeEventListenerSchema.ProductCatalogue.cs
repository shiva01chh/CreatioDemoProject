﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductDuplicateMergeEventListenerSchema

	/// <exclude/>
	public class ProductDuplicateMergeEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductDuplicateMergeEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductDuplicateMergeEventListenerSchema(ProductDuplicateMergeEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4791323-130d-4e3d-b054-ffcf10e6a861");
			Name = "ProductDuplicateMergeEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0dd62c3-7028-423e-b839-190adc6fc0eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,75,111,227,54,16,62,123,129,253,15,172,123,145,1,65,65,123,220,196,14,242,114,26,96,179,73,55,73,247,176,232,129,150,198,54,11,153,82,248,240,194,40,242,223,59,124,232,65,73,113,178,221,180,57,56,16,57,243,125,243,226,112,200,233,6,100,73,83,32,247,32,4,149,197,82,37,103,5,95,178,149,22,84,177,130,147,191,223,191,123,255,110,164,37,227,43,114,183,147,10,54,135,157,111,84,200,115,72,141,180,76,46,129,131,96,105,79,230,35,227,143,205,98,155,76,192,115,235,201,5,87,76,49,144,47,10,36,23,91,224,202,200,161,228,207,2,86,198,242,179,156,74,249,129,220,138,34,211,169,58,215,101,206,82,170,224,26,196,10,172,252,71,134,166,161,185,86,235,171,197,218,5,27,209,93,186,134,13,253,132,65,34,83,50,246,72,227,201,159,40,95,234,5,226,145,212,144,188,130,131,124,32,167,84,194,0,137,143,112,99,54,134,81,81,244,198,152,206,182,136,230,246,75,247,65,82,179,79,24,87,228,28,150,84,231,234,86,64,202,164,81,157,146,95,15,61,24,240,204,225,133,224,215,160,214,69,246,28,244,182,96,25,162,230,160,160,138,108,116,117,193,245,6,4,93,228,112,228,172,159,17,1,153,230,25,218,136,40,41,200,152,60,72,16,104,55,119,85,64,116,240,57,49,30,142,70,163,37,102,140,166,107,18,57,24,2,246,223,125,225,8,209,163,46,110,165,56,218,82,225,165,209,197,80,45,113,41,74,206,16,219,91,189,139,58,252,135,14,197,41,38,115,80,233,26,9,54,84,236,176,114,245,134,207,69,177,57,63,141,58,192,129,200,31,52,215,208,1,114,114,145,95,125,50,191,79,97,60,189,163,115,198,51,147,124,235,149,247,190,57,51,100,81,109,97,32,189,70,233,234,201,125,85,97,48,41,47,91,185,190,4,23,167,58,255,81,168,230,236,50,177,43,141,88,75,35,20,140,27,84,175,35,64,105,209,54,44,153,51,33,213,141,240,21,23,149,100,58,107,161,181,17,200,116,234,248,28,214,254,136,60,112,166,134,3,98,118,94,136,135,243,204,110,24,233,171,140,76,67,65,108,70,234,126,87,66,214,202,225,209,165,102,217,44,26,59,141,113,223,97,75,220,245,87,27,127,245,107,240,146,139,71,77,115,25,5,134,77,246,196,162,229,55,194,215,101,34,163,189,103,170,142,12,4,33,177,77,49,232,223,9,246,223,59,80,10,155,167,76,238,197,14,57,172,221,81,23,111,92,83,155,198,52,142,137,171,245,66,43,98,2,189,104,239,162,71,77,113,129,124,196,192,115,248,230,77,114,7,242,119,13,162,123,16,147,182,192,53,229,116,5,34,174,219,170,69,175,18,130,160,213,1,180,72,46,226,201,149,60,201,191,81,227,145,137,25,210,42,161,161,209,56,201,124,106,162,113,15,109,206,114,5,66,26,153,200,124,187,134,225,86,191,48,181,190,165,2,219,188,17,137,220,226,89,177,41,169,96,178,224,38,231,46,175,85,84,234,171,32,246,9,24,234,22,255,33,121,147,165,110,94,90,137,105,142,175,233,154,200,138,185,239,214,220,112,171,236,157,255,239,41,95,123,128,94,89,189,207,158,235,183,42,42,99,204,155,213,84,23,236,141,178,218,20,147,203,111,216,195,254,151,194,26,95,73,147,58,172,39,227,124,183,136,108,70,127,160,134,172,254,80,9,101,5,14,81,208,92,36,67,85,17,147,224,222,171,138,196,195,95,83,181,78,62,23,56,53,68,47,183,126,71,55,171,155,67,239,226,235,152,103,136,251,151,236,75,165,187,53,92,142,214,88,208,187,148,170,129,197,74,152,155,6,175,194,157,25,49,107,187,146,115,170,168,53,217,2,80,73,230,121,65,85,176,26,4,185,67,121,156,52,35,225,241,113,111,76,28,114,213,78,126,191,81,158,229,245,228,103,103,216,127,115,142,171,62,53,215,60,61,122,24,84,136,123,221,99,70,86,174,125,84,244,70,59,110,1,117,21,186,80,51,178,244,67,133,251,158,215,165,50,56,95,84,52,152,158,1,226,222,237,56,52,89,45,138,34,39,76,94,227,157,123,191,166,252,134,131,129,249,12,105,33,204,40,210,102,193,108,107,44,166,25,249,197,169,178,37,137,158,209,12,134,222,26,195,12,190,93,255,162,54,195,176,137,150,168,13,130,61,85,231,121,205,225,11,200,11,63,53,196,245,36,222,138,83,224,208,151,53,8,112,115,224,79,229,64,147,170,230,160,134,124,79,39,27,117,222,28,61,246,184,251,164,232,207,220,47,191,120,236,131,205,109,30,28,28,144,35,198,209,7,166,178,2,95,113,2,150,211,241,51,15,180,228,134,63,148,25,53,35,212,248,96,102,79,141,123,251,21,91,124,141,178,204,159,158,70,42,42,22,127,153,171,68,162,73,230,50,114,152,167,96,30,64,22,249,68,172,36,129,42,11,38,68,45,142,168,82,131,96,130,111,37,151,96,50,124,27,154,56,97,39,184,247,172,246,250,80,40,237,16,134,58,192,222,163,16,135,67,107,28,190,117,38,63,138,234,95,1,237,231,66,208,169,59,73,119,171,225,34,174,225,223,63,158,68,26,161,232,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4791323-130d-4e3d-b054-ffcf10e6a861"));
		}

		#endregion

	}

	#endregion

}
