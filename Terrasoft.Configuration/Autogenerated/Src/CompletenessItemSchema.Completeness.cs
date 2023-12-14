﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CompletenessItemSchema

	/// <exclude/>
	public class CompletenessItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CompletenessItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CompletenessItemSchema(CompletenessItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ef0c4479-30a0-4a34-89b0-15e8536921b6");
			Name = "CompletenessItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7d7292d2-00f9-4690-ab32-2183d65524ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,77,111,219,48,12,61,187,64,255,131,224,94,108,32,176,239,107,237,67,211,162,200,161,69,144,172,216,89,179,153,68,128,45,121,148,148,173,43,246,223,71,203,31,149,211,52,77,115,9,44,242,241,145,124,79,146,188,6,221,240,2,216,119,64,228,90,109,76,50,87,114,35,182,22,185,17,74,94,94,188,94,94,4,86,11,185,101,235,23,109,160,190,30,191,125,8,194,71,231,201,221,45,133,40,152,166,41,187,209,182,174,57,190,228,253,247,10,26,4,13,210,176,66,213,77,5,6,36,104,205,4,241,36,3,36,245,48,141,253,89,137,130,21,21,167,172,185,7,89,16,130,226,175,142,41,184,66,216,82,243,108,137,170,1,52,2,244,55,182,116,208,46,126,216,138,59,120,0,195,16,10,133,37,19,101,50,166,249,244,3,255,131,21,37,245,222,230,46,74,214,110,40,8,182,96,218,21,4,255,62,161,208,197,14,106,206,36,109,254,52,137,54,232,182,238,242,159,40,253,139,68,147,141,238,121,101,63,225,19,164,130,191,210,47,211,85,182,150,108,163,144,217,166,228,230,188,233,86,160,109,101,230,29,246,40,225,21,200,178,147,115,170,45,217,148,106,216,194,40,60,71,221,133,20,70,240,74,252,5,38,225,55,13,171,13,151,228,123,181,161,92,0,86,32,108,178,240,208,82,97,154,119,102,251,96,24,119,210,112,228,181,19,52,11,177,55,69,152,175,70,43,221,164,46,227,56,64,143,242,134,249,218,179,198,73,144,47,109,152,207,223,11,125,18,141,222,206,91,244,161,110,62,184,87,235,112,47,145,187,1,195,176,179,65,205,183,97,102,206,78,126,159,99,146,79,31,247,154,143,119,41,27,139,58,15,4,158,251,51,175,124,23,156,12,158,77,216,174,251,178,158,187,178,9,243,57,22,123,4,179,83,229,57,238,122,118,155,123,235,64,131,102,84,224,238,246,92,223,88,13,72,142,150,80,180,175,46,169,98,17,219,103,177,61,167,178,67,224,152,54,123,129,198,242,138,237,21,73,210,53,18,61,79,202,177,105,245,97,233,123,62,72,78,187,105,47,69,15,158,102,207,188,23,40,118,184,32,89,131,137,252,221,206,88,247,159,44,219,230,104,1,24,249,218,196,3,238,199,14,16,162,144,174,71,156,44,244,253,47,106,59,122,135,28,188,16,199,157,136,189,43,239,255,64,97,169,187,248,132,114,116,234,2,237,239,63,239,101,72,44,219,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ef0c4479-30a0-4a34-89b0-15e8536921b6"));
		}

		#endregion

	}

	#endregion

}

