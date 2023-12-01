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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,81,75,195,48,16,199,159,55,216,119,56,230,139,130,180,239,219,28,200,80,217,195,68,182,125,129,152,94,218,64,155,196,203,69,41,195,239,110,150,118,67,71,81,236,83,239,127,255,254,242,207,93,141,104,208,59,33,17,246,72,36,188,85,156,173,172,81,186,12,36,88,91,51,25,31,38,227,81,240,218,148,176,107,61,99,51,159,140,163,114,69,88,198,54,172,13,35,169,8,152,193,250,193,176,230,246,81,215,184,178,78,35,37,99,158,231,176,240,161,105,4,181,203,190,222,162,35,244,104,216,131,180,134,73,72,6,101,41,22,174,61,30,132,9,4,42,146,60,124,104,174,192,59,148,90,105,9,214,29,83,249,236,68,206,191,161,93,120,173,163,69,159,34,13,37,26,29,82,170,115,254,13,114,101,11,63,131,151,244,113,215,188,204,156,132,72,104,65,212,117,31,75,145,109,192,26,60,133,101,11,194,88,174,144,178,51,34,191,100,44,156,32,209,128,137,83,191,155,122,27,72,226,70,196,161,210,78,86,216,136,231,168,79,151,221,123,50,129,85,208,217,160,73,190,254,180,108,145,39,210,223,224,45,74,75,197,186,136,216,31,28,74,58,4,163,223,2,234,226,136,85,113,64,191,131,89,80,137,124,9,222,39,245,63,224,119,171,139,52,207,251,186,190,246,76,199,157,15,79,227,22,158,66,244,14,221,168,111,13,101,186,153,247,75,70,83,116,123,78,245,103,247,231,254,16,163,22,159,47,140,50,215,52,7,3,0,0 };
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

