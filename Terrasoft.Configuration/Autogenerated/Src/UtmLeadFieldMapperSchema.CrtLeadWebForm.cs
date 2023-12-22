namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmLeadFieldMapperSchema

	/// <exclude/>
	public class UtmLeadFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmLeadFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmLeadFieldMapperSchema(UtmLeadFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ece8268-d49a-43c7-9c1e-aa79f3fd3c89");
			Name = "UtmLeadFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,193,110,226,48,16,61,83,169,255,48,74,47,32,161,228,222,66,14,176,109,23,9,86,136,182,234,97,181,7,147,76,136,181,177,157,181,29,86,168,218,127,223,137,13,33,89,40,173,214,151,200,227,55,243,222,188,140,45,153,64,83,178,4,225,25,181,102,70,101,54,156,42,153,241,77,165,153,229,74,94,95,189,93,95,245,42,195,229,6,158,118,198,162,184,251,103,79,248,162,192,164,6,155,240,17,37,106,158,156,96,230,92,254,58,6,219,92,26,195,7,150,88,165,57,26,66,16,230,70,227,134,138,193,180,96,198,220,194,139,21,115,100,233,3,199,34,93,176,178,68,237,80,81,20,193,136,203,156,232,108,170,18,72,52,102,227,96,214,130,5,81,76,184,239,95,48,99,85,97,39,92,166,196,221,183,187,18,85,214,159,77,43,99,149,104,193,7,67,248,70,110,192,24,130,83,202,96,240,131,106,149,213,186,224,68,85,11,59,163,11,110,225,180,44,165,189,57,193,199,190,200,40,203,164,165,222,150,154,111,153,69,127,238,58,50,149,16,76,239,226,67,224,57,71,152,44,23,144,83,123,144,213,101,195,6,27,181,193,165,47,5,73,93,29,140,213,181,209,147,82,124,165,68,39,167,110,108,191,15,238,62,193,72,56,212,40,105,52,254,135,118,213,101,93,29,73,111,80,166,222,137,174,45,75,173,200,46,75,99,64,190,56,163,47,136,124,68,107,192,146,210,223,184,206,149,250,9,70,85,58,193,247,68,250,255,182,87,247,234,83,158,92,6,140,227,110,160,249,59,225,156,185,137,225,151,204,106,116,160,180,220,238,64,210,4,125,74,196,189,195,251,129,139,33,168,39,233,35,131,22,104,115,149,158,115,231,226,53,8,233,227,182,198,95,136,131,144,173,226,41,52,103,253,217,189,172,4,106,182,46,112,228,53,198,7,115,61,98,8,115,110,236,104,111,22,93,250,74,72,74,143,65,212,52,254,30,152,1,208,176,67,107,181,15,195,21,150,5,189,53,253,246,88,14,27,251,81,111,121,219,255,37,219,224,139,46,28,106,80,63,30,189,222,123,213,86,31,22,91,213,211,172,81,119,11,254,57,235,184,143,118,131,46,214,90,127,1,184,36,75,17,57,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ece8268-d49a-43c7-9c1e-aa79f3fd3c89"));
		}

		#endregion

	}

	#endregion

}

