﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormSubmitEventListenerSchema

	/// <exclude/>
	public class FormSubmitEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormSubmitEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormSubmitEventListenerSchema(FormSubmitEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2fb6988-fe08-435e-9093-741348929bb6");
			Name = "FormSubmitEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1d561c9f-c9ca-4727-b788-d69dbba5c4dc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,81,111,218,48,16,126,166,82,255,195,45,123,73,164,138,188,211,66,53,42,182,85,162,45,42,116,123,152,166,201,36,23,240,154,216,200,118,152,162,170,255,125,103,39,41,166,132,49,30,66,114,247,221,221,119,159,125,39,88,129,122,195,18,132,5,42,197,180,204,76,255,70,138,140,175,74,197,12,151,226,252,236,229,252,172,87,106,46,86,123,144,162,144,226,178,211,163,176,63,17,134,27,142,250,36,160,63,217,162,48,22,71,200,143,10,87,84,17,110,114,166,245,0,62,75,85,204,203,101,193,141,3,77,185,54,40,80,57,104,28,199,112,165,203,162,96,170,26,53,223,45,0,50,169,200,137,8,137,194,108,24,236,242,4,241,8,208,86,174,0,93,221,126,155,42,126,151,203,134,179,92,203,38,197,152,105,116,148,171,61,42,1,196,54,224,71,135,43,156,39,107,44,216,61,201,11,67,16,244,39,179,112,199,36,138,126,82,224,166,92,230,60,129,196,246,123,172,93,24,192,145,234,148,224,197,137,241,38,220,76,201,13,42,171,235,0,102,46,119,237,127,175,150,51,220,10,109,152,160,131,151,153,175,214,29,83,207,104,232,200,158,76,49,99,74,83,151,164,154,145,144,113,145,66,206,197,51,166,181,136,84,6,150,21,148,166,128,13,83,172,112,106,30,202,217,219,40,190,101,6,225,48,51,252,42,219,215,75,135,172,245,232,0,238,222,236,109,236,245,86,104,96,56,242,226,225,250,26,66,239,147,52,199,63,29,153,194,40,114,165,122,250,32,195,16,182,44,47,209,185,95,27,97,81,164,181,182,251,66,223,161,89,203,212,170,92,247,86,123,219,70,183,146,167,48,38,185,166,78,173,246,174,123,199,223,220,194,168,233,134,103,16,126,168,77,253,91,125,35,243,178,16,223,44,151,169,100,41,166,97,48,101,34,165,46,102,108,133,79,143,211,32,106,3,123,10,77,169,68,221,209,171,123,110,153,130,220,131,171,156,26,107,114,127,65,179,168,54,152,122,21,174,180,81,4,29,29,214,184,124,163,86,67,136,217,125,153,231,15,234,251,154,27,156,219,157,17,238,23,58,69,107,89,230,207,147,130,241,252,54,37,78,111,71,98,105,141,91,215,184,34,123,216,240,125,34,47,45,35,129,137,221,68,23,239,250,242,24,122,153,45,77,105,38,197,198,84,225,142,80,147,112,142,198,235,61,12,198,187,184,224,194,231,23,121,220,255,251,46,156,154,184,175,68,63,167,161,57,181,155,60,255,131,160,49,181,35,45,86,14,96,231,255,200,152,57,139,27,68,183,110,134,129,38,194,52,189,35,183,52,160,254,234,95,197,14,210,29,129,193,104,177,70,191,254,98,112,116,113,59,174,99,164,101,139,174,194,39,181,210,118,33,2,111,23,75,34,133,97,92,216,245,111,214,216,86,116,61,64,202,12,219,35,211,204,190,220,82,61,158,54,67,228,181,31,202,229,111,186,7,77,31,23,208,89,31,176,61,241,37,237,204,190,31,222,198,97,115,180,246,66,54,122,15,193,223,204,53,176,6,117,12,113,51,185,255,216,18,181,117,223,232,108,246,247,23,243,228,227,136,112,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2fb6988-fe08-435e-9093-741348929bb6"));
		}

		#endregion

	}

	#endregion

}

