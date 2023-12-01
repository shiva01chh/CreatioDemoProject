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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,80,177,78,195,48,16,157,99,41,255,112,18,75,89,146,189,32,150,138,141,1,137,168,204,23,115,73,44,57,118,116,103,211,150,138,127,199,113,82,40,11,76,246,189,187,123,239,221,115,56,146,76,168,9,26,98,70,241,93,168,118,222,117,166,143,140,193,120,87,53,140,78,108,254,151,234,92,170,34,138,113,61,188,156,36,208,120,87,170,132,220,48,245,169,13,59,139,34,91,120,101,19,232,201,107,180,230,3,91,75,123,180,145,30,143,154,166,133,36,109,212,117,13,247,18,199,17,249,244,176,214,205,64,64,151,41,8,3,6,48,146,94,246,7,7,135,129,28,8,190,19,248,137,22,103,115,215,249,0,18,181,38,145,46,218,234,194,92,95,81,79,177,181,70,131,158,189,253,99,13,182,112,101,179,56,103,171,63,215,121,39,129,163,14,158,211,145,207,153,118,153,88,37,254,38,223,164,229,57,184,148,183,96,79,183,73,172,69,161,205,119,61,103,91,124,174,154,228,222,22,217,92,47,232,111,48,99,74,125,1,173,202,234,169,193,1,0,0 };
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

