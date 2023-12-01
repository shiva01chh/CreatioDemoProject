﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AudienceSegmentationQuerySourceSchema

	/// <exclude/>
	public class AudienceSegmentationQuerySourceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AudienceSegmentationQuerySourceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AudienceSegmentationQuerySourceSchema(AudienceSegmentationQuerySourceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2befff3-d3b6-2254-30ec-f5ee35757d0b");
			Name = "AudienceSegmentationQuerySource";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,75,111,219,56,16,62,171,64,255,3,161,189,40,64,43,223,227,36,128,227,38,69,14,9,186,118,186,61,20,139,5,43,141,29,162,20,169,240,145,68,40,242,223,119,72,74,10,37,91,118,23,88,3,134,205,225,60,191,121,81,208,10,116,77,11,32,247,160,20,213,114,99,242,165,20,27,182,181,138,26,38,197,251,119,191,222,191,75,172,102,98,75,214,141,54,80,205,251,115,44,162,96,138,158,127,186,156,188,186,18,134,25,6,26,25,144,229,15,5,91,52,73,150,156,106,125,74,22,182,100,32,10,88,195,182,2,97,188,59,127,90,80,205,90,90,85,128,23,153,205,102,228,76,219,170,162,170,185,104,207,94,156,24,73,182,96,136,6,14,133,249,248,232,228,28,77,7,101,132,182,202,243,78,201,44,210,82,219,31,156,21,164,240,138,142,186,145,252,242,174,244,238,95,51,224,37,250,255,69,177,39,106,28,67,226,190,117,56,18,5,180,148,130,55,228,171,6,133,88,11,244,207,137,253,99,7,231,121,171,20,68,25,244,14,141,32,163,54,202,22,70,42,103,202,59,28,56,198,144,4,76,208,170,1,77,24,74,81,12,134,200,13,50,1,144,66,193,230,60,61,18,99,58,235,21,13,112,10,148,154,42,90,17,129,149,116,158,14,99,72,47,150,86,41,7,183,163,147,162,191,56,155,121,33,175,163,5,251,136,11,217,8,173,161,161,19,226,170,52,73,70,24,146,115,178,3,106,146,188,30,70,246,22,204,131,28,228,47,206,222,147,100,37,89,148,229,82,114,91,9,125,47,215,190,192,50,95,201,205,186,120,128,138,122,183,9,232,199,15,36,38,19,237,127,58,95,123,37,223,24,26,180,230,19,211,53,167,205,95,148,91,200,188,112,138,142,27,90,152,244,237,239,77,153,158,204,127,87,252,150,98,132,140,115,20,194,211,10,10,86,35,196,230,107,175,228,245,80,108,251,244,78,68,137,149,232,154,187,240,114,163,227,130,51,170,187,152,119,228,175,94,106,5,90,59,220,3,123,68,56,247,34,187,50,121,40,230,64,9,190,142,116,101,157,39,232,93,190,146,210,4,222,22,185,177,161,28,1,193,74,249,108,89,153,223,193,179,251,205,90,214,39,170,8,140,237,7,147,40,33,224,153,236,120,23,110,91,15,186,184,19,15,95,28,219,78,184,158,239,53,152,157,48,153,175,193,92,75,108,134,50,34,122,205,30,228,44,6,188,85,132,241,247,9,205,38,212,30,172,133,107,198,13,40,61,149,121,7,22,249,97,249,207,171,138,50,44,180,46,96,103,184,21,117,14,184,130,108,211,22,168,174,184,190,184,17,0,94,123,32,46,101,133,99,129,105,41,238,155,26,151,195,163,165,28,11,247,178,83,143,85,28,155,138,98,252,223,77,173,112,43,226,132,133,244,67,200,223,45,210,176,166,253,212,213,249,14,219,10,103,122,227,102,129,40,127,199,177,59,105,174,94,24,106,10,215,89,250,61,210,216,118,233,10,106,28,139,244,180,39,220,148,167,111,13,253,119,238,154,120,111,230,6,35,39,216,235,102,107,124,149,117,169,82,96,172,218,89,63,121,204,139,118,233,22,84,254,25,204,77,187,64,46,155,59,68,52,123,67,236,158,42,220,183,233,73,190,228,82,0,106,167,122,224,202,49,87,67,81,77,251,235,239,179,3,243,212,247,170,126,156,234,203,108,200,157,224,62,89,148,21,19,43,182,125,48,26,165,54,148,107,24,116,33,230,11,119,128,91,118,113,19,222,232,5,127,166,141,14,131,191,19,156,199,88,162,228,127,219,52,199,214,55,2,175,135,79,153,141,196,104,29,238,253,75,6,167,221,75,1,53,62,109,184,123,98,52,221,83,7,74,124,114,20,82,149,58,63,176,196,131,231,250,226,108,214,253,139,118,243,19,83,6,27,132,180,33,163,55,111,219,218,111,191,169,49,176,39,93,8,216,161,162,156,239,223,19,109,102,143,149,135,142,231,252,158,45,29,182,213,136,169,27,113,254,50,14,98,156,83,87,255,65,81,176,54,106,153,147,3,57,15,212,152,232,41,248,249,23,6,173,165,79,130,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2befff3-d3b6-2254-30ec-f5ee35757d0b"));
		}

		#endregion

	}

	#endregion

}
