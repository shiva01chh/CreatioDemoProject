namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationHandlerSchema

	/// <exclude/>
	public class INotificationHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationHandlerSchema(INotificationHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9c66d6e-bd4a-4fc2-8d6b-edbb5e21ba56");
			Name = "INotificationHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,78,195,48,12,134,207,171,212,119,176,118,130,203,242,0,148,94,16,130,94,16,18,123,1,47,115,70,164,196,169,156,4,105,66,123,247,165,237,128,150,70,190,196,246,255,253,182,25,61,197,30,53,193,158,68,48,6,147,118,79,129,141,61,101,193,100,3,215,213,119,93,109,114,180,124,130,143,115,76,228,75,221,57,210,67,49,238,94,136,73,172,126,168,171,210,165,148,130,38,102,239,81,206,237,237,223,113,34,49,131,129,9,2,189,4,77,113,132,113,72,214,88,141,19,231,71,173,102,242,62,31,156,213,96,127,9,221,219,76,243,138,124,116,36,165,111,24,112,229,61,38,222,39,59,138,107,183,181,221,148,233,81,208,3,151,179,60,110,23,162,109,251,183,55,4,3,233,147,254,81,27,53,138,71,214,87,176,71,152,70,188,235,158,57,123,18,60,56,106,22,43,116,108,66,187,132,220,151,75,110,46,117,85,98,254,174,188,208,91,233,167,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9c66d6e-bd4a-4fc2-8d6b-edbb5e21ba56"));
		}

		#endregion

	}

	#endregion

}

