namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Base64ImageSchema

	/// <exclude/>
	public class Base64ImageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Base64ImageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Base64ImageSchema(Base64ImageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efe46806-614f-4213-8fdf-a9bbacc250fd");
			Name = "Base64Image";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,82,203,78,195,48,16,60,167,82,255,97,149,94,64,42,201,5,113,232,35,7,170,30,122,8,234,161,63,224,166,219,96,41,182,35,219,57,84,136,127,199,207,146,66,42,10,23,162,40,114,198,158,217,153,245,114,194,80,181,164,66,216,161,148,68,137,163,206,86,130,31,105,221,73,162,169,224,89,73,104,67,121,61,30,189,141,71,201,68,98,109,64,88,53,68,169,25,60,19,133,79,143,27,70,106,52,155,230,205,243,28,22,170,99,140,200,83,17,254,221,54,72,108,37,42,228,26,15,64,20,236,29,19,148,150,70,59,139,204,188,71,109,187,125,67,43,168,108,165,47,133,172,147,79,43,130,27,149,174,210,66,26,71,91,199,242,102,188,102,75,36,97,192,77,206,101,202,40,195,221,169,197,180,40,55,229,250,65,155,37,136,35,232,87,4,106,181,179,69,238,142,23,131,236,74,24,247,92,167,197,202,47,174,83,131,247,158,235,59,159,20,162,131,105,136,14,65,244,222,210,146,153,209,163,42,156,205,214,172,213,167,105,143,18,207,130,107,192,251,181,148,246,155,22,47,230,251,139,112,255,223,26,171,116,110,203,213,62,249,236,137,75,183,116,156,185,3,202,64,48,96,228,250,141,232,104,25,37,230,253,230,77,144,31,252,32,69,32,140,213,86,138,22,165,166,56,56,84,189,57,117,192,247,102,159,143,246,103,58,166,15,153,28,203,231,169,209,251,74,20,94,26,28,44,103,195,14,92,209,45,53,207,125,250,75,221,193,219,189,165,106,36,254,80,244,226,54,2,216,199,12,100,158,15,229,156,208,152,180,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efe46806-614f-4213-8fdf-a9bbacc250fd"));
		}

		#endregion

	}

	#endregion

}

