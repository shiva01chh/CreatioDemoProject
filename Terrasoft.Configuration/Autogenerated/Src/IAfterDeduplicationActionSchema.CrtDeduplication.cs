namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAfterDeduplicationActionSchema

	/// <exclude/>
	public class IAfterDeduplicationActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAfterDeduplicationActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAfterDeduplicationActionSchema(IAfterDeduplicationActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aec23552-782f-4407-a3bb-de7bbc336923");
			Name = "IAfterDeduplicationAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b7fcaef-4d0d-4f1c-b466-136a63eb8599");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,107,2,49,16,134,207,46,236,127,24,236,165,189,36,119,221,10,82,61,120,16,74,233,31,72,55,179,107,96,243,65,62,68,145,254,247,166,19,87,86,41,205,41,243,102,222,135,119,38,70,104,12,78,180,8,159,232,189,8,182,139,236,205,154,78,245,201,139,168,172,97,27,148,201,13,170,165,170,174,46,117,53,75,65,153,254,206,224,145,109,77,84,81,97,88,214,85,110,121,242,216,231,126,216,153,136,190,203,252,5,236,214,93,190,223,225,214,109,129,102,3,231,28,154,144,180,22,254,188,186,214,31,232,60,6,52,49,128,128,131,48,114,64,15,120,194,54,69,148,32,126,113,32,167,60,104,173,118,3,70,100,35,145,79,144,46,125,229,70,80,99,164,255,18,205,46,148,234,54,199,30,227,193,202,176,128,119,130,148,199,199,204,36,108,254,12,52,198,103,55,31,127,52,54,78,120,161,193,228,31,121,157,107,244,61,74,218,233,121,190,218,83,5,121,25,105,136,128,164,178,134,147,129,252,71,171,36,108,203,102,158,139,11,166,136,151,229,117,28,52,178,76,68,245,119,249,171,137,72,202,244,252,0,53,73,189,154,33,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aec23552-782f-4407-a3bb-de7bbc336923"));
		}

		#endregion

	}

	#endregion

}

