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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,82,203,78,195,48,16,60,167,82,255,97,149,94,64,42,201,5,113,232,35,7,170,30,122,8,234,161,63,224,166,219,96,41,182,35,219,57,84,136,127,199,241,163,184,144,138,194,133,40,138,156,177,103,118,102,189,156,48,84,45,169,16,118,40,37,81,226,168,179,149,224,71,90,119,146,104,42,120,86,18,218,80,94,143,71,111,227,81,50,145,88,27,16,86,13,81,106,6,207,68,225,211,227,134,145,26,205,166,121,243,60,135,133,234,24,35,242,84,248,127,187,13,18,91,137,10,185,198,3,16,5,123,203,4,165,165,209,206,2,51,143,168,109,183,111,104,5,85,95,233,75,161,222,201,167,21,193,141,74,87,105,33,141,163,173,101,57,51,78,179,37,146,48,224,38,231,50,101,148,225,238,212,98,90,148,155,114,253,160,205,18,196,17,244,43,2,237,181,179,69,110,143,23,131,236,74,24,247,92,167,197,202,45,174,83,189,247,200,245,157,75,10,193,193,212,71,7,47,122,223,211,146,153,209,163,202,159,205,214,172,213,167,105,68,9,103,193,54,224,253,90,202,254,155,22,47,230,251,139,112,255,223,154,94,233,220,150,171,125,114,217,19,155,110,105,57,115,11,148,158,96,192,192,117,27,193,209,50,72,204,227,230,77,144,31,220,32,5,192,143,213,86,138,22,165,166,56,56,84,209,156,90,224,123,179,207,71,227,153,14,233,125,38,203,114,121,106,116,190,18,133,151,6,7,203,245,97,7,174,232,150,154,231,62,253,165,238,224,237,222,82,53,16,127,40,122,113,27,30,140,49,3,197,207,7,38,112,212,135,189,4,0,0 };
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

