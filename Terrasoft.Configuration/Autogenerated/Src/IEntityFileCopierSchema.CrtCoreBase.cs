namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEntityFileCopierSchema

	/// <exclude/>
	public class IEntityFileCopierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEntityFileCopierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEntityFileCopierSchema(IEntityFileCopierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c02c3b56-5b96-4366-af70-1c204d27c6c2");
			Name = "IEntityFileCopier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,81,75,195,48,16,199,159,55,216,119,56,230,139,130,180,239,219,28,200,80,217,195,68,182,125,129,152,94,218,64,155,139,151,68,41,195,239,110,154,118,67,199,80,236,83,239,127,255,254,242,207,93,141,104,208,89,33,17,246,200,44,28,41,159,173,200,40,93,6,22,94,147,153,140,15,147,241,40,56,109,74,216,181,206,99,51,159,140,163,114,197,88,198,54,172,141,71,86,17,48,131,245,131,241,218,183,143,186,198,21,89,141,156,140,121,158,195,194,133,166,17,220,46,135,122,139,150,209,161,241,14,36,25,207,66,122,80,196,177,176,109,119,16,38,16,168,72,114,240,161,125,5,206,162,212,74,75,32,219,165,114,217,145,156,127,67,219,240,90,71,139,62,70,186,148,104,116,72,169,78,249,55,232,43,42,220,12,94,210,199,125,243,60,115,18,34,161,5,81,215,67,44,197,212,0,25,60,134,245,4,194,144,175,144,179,19,34,63,103,44,172,96,209,128,137,83,191,155,58,10,44,113,35,226,80,121,39,43,108,196,115,212,167,203,254,61,153,128,20,244,54,104,146,111,56,45,91,228,137,244,55,120,139,146,184,88,23,17,251,131,195,73,135,96,244,91,64,93,116,88,21,7,244,59,216,11,46,209,159,131,247,73,253,15,248,157,116,145,230,121,95,215,215,206,115,183,243,203,211,184,133,167,16,189,151,110,52,180,46,101,186,153,15,75,70,83,244,123,78,245,103,255,231,254,16,163,214,61,95,170,30,237,214,8,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c02c3b56-5b96-4366-af70-1c204d27c6c2"));
		}

		#endregion

	}

	#endregion

}

