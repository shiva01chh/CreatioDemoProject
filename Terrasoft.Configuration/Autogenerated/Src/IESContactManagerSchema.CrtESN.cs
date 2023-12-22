namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESContactManagerSchema

	/// <exclude/>
	public class IESContactManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESContactManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESContactManagerSchema(IESContactManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d67308e4-6320-4c6b-bc57-690f1d4497fe");
			Name = "IESContactManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,221,74,195,48,20,190,86,240,29,14,243,70,65,90,175,93,87,144,49,101,224,116,184,189,64,150,157,118,193,54,153,231,36,202,16,223,221,147,182,171,58,21,123,83,242,229,251,57,63,177,170,70,222,42,141,176,68,34,197,174,240,201,216,217,194,148,129,148,55,206,38,147,197,253,201,241,219,201,241,81,96,99,75,88,236,216,99,45,156,170,66,29,9,156,220,162,69,50,122,120,200,89,110,8,213,90,128,100,169,248,137,229,94,24,167,132,165,168,96,106,61,82,33,193,87,48,157,44,38,181,50,213,76,89,85,34,9,41,77,83,200,56,212,181,162,93,222,157,231,228,94,204,26,25,106,244,27,183,102,40,28,129,118,214,43,237,25,24,21,233,77,204,218,203,211,47,250,109,88,85,70,131,217,103,198,200,113,43,253,12,125,107,234,235,11,156,181,49,87,48,111,196,237,229,97,97,13,176,104,178,251,90,146,158,152,30,50,179,173,34,85,131,149,161,143,6,132,207,1,217,15,242,59,195,30,92,209,245,0,236,73,250,224,36,75,27,246,31,98,247,58,118,193,138,186,249,69,185,64,44,45,2,161,15,100,225,69,85,1,255,53,225,135,162,96,20,155,199,168,118,205,33,154,148,113,167,170,18,51,222,202,142,127,49,106,99,184,175,62,99,68,208,132,197,104,208,141,246,198,209,12,109,124,35,131,52,23,131,189,34,90,196,23,145,77,39,54,212,18,179,170,48,251,161,201,243,110,176,221,13,95,243,206,234,179,24,151,181,35,202,161,27,225,69,220,44,236,71,2,35,184,236,145,174,191,136,157,15,187,5,163,93,183,59,110,206,239,237,179,252,6,10,246,245,251,0,162,68,68,61,37,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d67308e4-6320-4c6b-bc57-690f1d4497fe"));
		}

		#endregion

	}

	#endregion

}

