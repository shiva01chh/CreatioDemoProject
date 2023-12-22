namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeleteHandlerSchema

	/// <exclude/>
	public class IDeleteHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeleteHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeleteHandlerSchema(IDeleteHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20195bd2-50b1-4e93-a074-7128a08c449a");
			Name = "IDeleteHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,207,78,132,48,16,198,207,107,226,59,76,118,47,122,129,187,139,92,148,40,7,47,171,47,80,232,64,154,208,150,76,219,68,178,241,221,237,31,96,137,198,184,61,117,134,239,235,143,111,50,138,73,52,35,107,17,62,144,136,25,221,217,236,73,171,78,244,142,152,21,90,193,249,246,102,231,140,80,61,188,79,198,162,60,174,245,214,65,152,85,202,10,43,208,120,129,151,28,8,251,96,175,149,69,234,60,224,1,234,103,28,208,226,43,83,124,64,138,170,60,207,161,48,78,74,70,83,57,215,181,28,7,148,168,44,240,168,7,194,86,19,7,221,1,6,196,148,45,198,124,227,28,93,51,136,22,196,130,251,65,11,49,188,234,23,48,54,78,104,29,41,3,248,217,226,24,67,123,86,130,103,171,105,11,219,85,171,242,114,59,67,143,246,8,95,215,128,136,52,129,159,188,97,61,254,11,51,150,194,184,171,96,122,155,61,87,192,82,126,51,15,13,154,105,25,164,224,161,213,9,164,63,128,177,51,50,98,18,148,223,143,199,125,50,214,124,95,86,233,177,205,19,69,30,149,23,35,165,144,229,9,141,27,236,38,93,145,47,159,130,182,209,122,152,255,241,238,197,9,14,11,228,62,45,80,138,118,64,197,211,38,133,50,246,182,231,27,18,12,247,81,191,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20195bd2-50b1-4e93-a074-7128a08c449a"));
		}

		#endregion

	}

	#endregion

}

