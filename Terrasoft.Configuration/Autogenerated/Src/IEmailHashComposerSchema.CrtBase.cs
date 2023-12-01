namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailHashComposerSchema

	/// <exclude/>
	public class IEmailHashComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailHashComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailHashComposerSchema(IEmailHashComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4ee924f-2761-4cad-9702-50f6fc4e2bb2");
			Name = "IEmailHashComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,147,193,110,194,48,12,134,207,32,237,29,44,184,108,210,212,222,161,244,2,8,56,76,67,27,123,128,208,186,16,41,77,43,39,153,132,208,222,125,110,2,29,20,14,211,142,235,45,246,239,191,159,255,180,90,148,104,106,145,33,108,144,72,152,170,176,209,180,210,133,220,57,18,86,86,250,161,127,124,232,247,156,145,122,7,239,7,99,177,28,119,206,172,87,10,179,70,108,162,5,106,36,153,253,104,46,109,9,185,206,157,33,225,142,213,176,210,22,169,224,151,143,96,53,47,133,84,75,97,246,211,170,172,43,131,228,149,113,28,67,98,92,89,10,58,164,167,243,154,170,79,153,163,1,81,75,40,42,2,108,70,129,247,48,98,135,176,103,15,110,102,66,101,78,168,134,42,58,27,197,23,78,181,219,42,153,129,60,35,220,37,232,29,61,69,11,252,130,118,95,229,102,4,107,63,29,154,93,70,95,128,55,180,142,180,105,113,218,140,2,153,18,22,115,216,30,78,240,181,32,190,8,70,49,81,107,25,119,61,19,175,2,205,202,201,192,49,32,95,148,14,166,131,52,49,136,144,17,22,147,193,199,117,43,78,121,75,99,133,206,48,74,98,239,113,223,210,163,12,210,121,151,232,102,136,194,110,39,229,205,134,60,112,86,52,35,171,185,118,37,146,216,42,76,140,37,254,40,82,88,160,93,250,177,199,107,88,184,94,235,25,218,75,153,109,94,67,86,79,227,223,196,158,99,33,156,178,30,238,95,38,222,9,57,4,219,228,58,11,155,55,153,253,61,220,33,234,60,124,243,254,252,21,126,219,171,162,175,241,243,13,167,9,225,47,66,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4ee924f-2761-4cad-9702-50f6fc4e2bb2"));
		}

		#endregion

	}

	#endregion

}

