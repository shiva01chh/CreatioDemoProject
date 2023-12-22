namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRepositorySchema

	/// <exclude/>
	public class IRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRepositorySchema(IRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb47eba1-93f4-4a26-a75c-b68259fb6949");
			Name = "IRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,75,195,64,16,61,87,240,63,12,241,82,65,146,187,198,128,138,150,222,164,13,120,222,36,211,186,176,31,97,63,148,32,254,119,103,179,77,140,85,171,130,185,237,228,205,155,247,222,78,162,152,68,219,178,26,161,68,99,152,213,27,151,222,104,181,225,91,111,152,227,90,29,31,189,28,31,205,188,229,106,11,235,206,58,148,23,123,103,194,11,129,117,0,219,116,129,10,13,175,9,67,168,19,131,91,170,194,82,57,52,27,26,114,14,203,21,182,218,114,167,77,215,67,178,44,131,220,122,41,153,233,138,221,185,68,217,10,230,176,1,51,130,193,105,96,149,117,134,213,14,44,85,216,22,211,161,63,219,35,200,93,215,98,203,12,147,160,200,223,101,82,38,197,154,122,136,17,149,227,142,216,8,144,230,217,136,11,157,173,175,4,175,129,15,98,167,90,243,178,128,231,71,52,20,19,156,195,53,179,24,248,88,37,240,182,39,164,246,16,211,39,59,125,97,133,206,27,101,135,217,85,7,188,73,71,116,182,15,207,167,202,121,147,20,113,68,104,202,179,81,109,132,154,72,189,131,208,251,161,16,16,37,220,113,213,204,23,158,55,212,124,26,239,228,107,137,55,6,41,240,81,34,87,67,198,192,84,184,134,104,128,59,251,7,233,145,43,41,122,238,176,46,56,136,60,104,34,250,156,250,232,13,68,133,243,114,199,114,208,205,10,165,126,194,255,14,252,73,147,140,72,253,155,76,103,107,100,166,126,196,16,27,74,27,84,180,180,129,188,38,27,41,252,82,205,208,209,119,37,197,253,72,240,109,136,113,42,93,153,245,194,237,5,185,188,85,94,98,191,182,97,161,31,194,66,207,239,188,170,243,242,12,42,173,69,1,31,6,254,16,242,251,86,211,119,49,249,38,191,51,54,74,220,173,86,159,203,97,137,11,116,87,66,204,131,144,217,107,252,167,160,106,226,111,37,28,169,54,125,222,0,222,210,118,212,206,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb47eba1-93f4-4a26-a75c-b68259fb6949"));
		}

		#endregion

	}

	#endregion

}

