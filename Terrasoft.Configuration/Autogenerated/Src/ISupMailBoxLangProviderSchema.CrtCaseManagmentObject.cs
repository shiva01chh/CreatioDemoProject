namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupMailBoxLangProviderSchema

	/// <exclude/>
	public class ISupMailBoxLangProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupMailBoxLangProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupMailBoxLangProviderSchema(ISupMailBoxLangProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15f7828f-b2b8-4927-9695-3e8e4374d7a6");
			Name = "ISupMailBoxLangProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,145,207,106,195,48,12,198,207,11,228,29,68,79,27,140,228,1,150,229,176,13,202,160,131,66,247,2,174,43,103,130,248,15,178,61,90,198,222,125,114,178,208,178,30,103,124,145,244,147,190,79,182,83,22,99,80,26,225,29,153,85,244,38,53,207,222,25,26,50,171,68,222,213,213,87,93,221,228,72,110,128,221,41,38,180,15,127,98,225,199,17,117,129,99,179,70,135,76,90,24,161,218,182,133,46,102,107,21,159,250,223,248,5,163,102,218,99,132,116,10,120,15,233,67,37,8,236,63,233,32,185,81,185,33,171,1,193,176,183,96,21,141,176,247,71,41,24,207,64,78,11,228,18,48,14,20,211,236,175,89,116,218,11,161,144,247,35,105,105,72,200,166,44,247,186,203,225,77,166,61,249,227,70,36,182,179,30,11,90,182,187,50,58,37,182,255,51,117,237,106,206,4,197,202,130,147,119,127,92,49,106,10,36,221,113,213,111,164,27,188,1,44,2,177,233,218,9,60,247,49,166,204,46,246,155,197,205,36,75,134,144,5,94,170,5,95,103,58,192,26,211,66,222,150,209,157,120,147,63,235,225,172,121,87,126,242,187,174,228,94,158,31,34,140,226,126,19,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15f7828f-b2b8-4927-9695-3e8e4374d7a6"));
		}

		#endregion

	}

	#endregion

}

