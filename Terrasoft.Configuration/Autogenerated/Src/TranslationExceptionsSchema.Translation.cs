namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationExceptionsSchema

	/// <exclude/>
	public class TranslationExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationExceptionsSchema(TranslationExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd34e1f4-8c12-45a5-b98a-235cdfe34c22");
			Name = "TranslationExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,80,177,78,196,48,12,157,91,169,255,96,137,229,88,218,253,64,44,39,54,6,36,170,99,118,131,219,70,74,147,202,78,184,59,78,252,59,105,210,131,99,129,44,142,159,237,247,158,109,113,34,153,81,17,180,196,140,226,122,95,239,156,237,245,16,24,189,118,182,110,25,173,152,244,175,202,115,85,22,65,180,29,224,229,36,158,166,187,170,140,200,13,211,16,203,176,51,40,178,133,87,214,158,158,156,66,163,63,176,51,180,71,19,232,241,168,104,206,36,113,162,105,26,184,151,48,77,200,167,135,53,111,71,2,186,116,129,31,209,131,150,24,217,29,44,28,70,178,32,248,78,224,102,202,206,150,170,117,30,36,40,69,34,125,48,245,133,185,185,162,158,67,103,180,2,181,120,251,199,26,108,225,202,102,113,78,86,127,182,115,86,60,7,229,29,199,37,159,19,109,238,88,37,254,38,223,196,225,229,112,241,222,130,3,221,70,177,14,133,54,223,249,114,219,226,115,213,36,251,150,101,83,158,209,223,96,194,226,251,2,12,51,25,154,194,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd34e1f4-8c12-45a5-b98a-235cdfe34c22"));
		}

		#endregion

	}

	#endregion

}

