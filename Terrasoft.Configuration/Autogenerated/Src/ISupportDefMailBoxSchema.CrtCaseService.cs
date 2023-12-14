namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupportDefMailBoxSchema

	/// <exclude/>
	public class ISupportDefMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupportDefMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupportDefMailBoxSchema(ISupportDefMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c365918f-f01b-41e0-998d-6395d5736989");
			Name = "ISupportDefMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,141,77,10,194,64,12,70,215,22,122,135,44,117,211,57,128,165,11,21,196,133,171,122,129,105,201,148,129,206,15,73,6,90,196,187,59,131,212,69,67,32,240,229,229,197,107,135,28,245,136,240,66,34,205,193,72,115,13,222,216,41,145,22,27,124,93,189,235,234,16,211,48,219,17,172,23,36,83,232,71,159,98,12,36,55,52,79,109,231,75,88,50,85,200,131,82,10,90,78,206,105,90,187,45,184,163,0,255,46,192,101,30,134,176,128,161,224,128,87,22,204,3,69,172,159,154,191,65,237,21,45,161,36,242,220,245,59,79,211,170,109,85,88,22,202,162,242,241,120,58,231,224,83,87,185,75,125,1,32,94,104,115,236,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c365918f-f01b-41e0-998d-6395d5736989"));
		}

		#endregion

	}

	#endregion

}

