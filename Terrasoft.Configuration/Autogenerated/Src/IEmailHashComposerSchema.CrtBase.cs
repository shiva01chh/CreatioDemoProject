namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailHashComposerSchema

	/// <exclude/>
	public class IEmailHashComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailHashComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailHashComposerSchema(IEmailHashComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4ee924f-2761-4cad-9702-50f6fc4e2bb2");
			Name = "IEmailHashComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,147,177,110,194,48,16,134,103,144,250,14,39,88,90,169,74,118,8,89,0,1,67,85,212,210,7,48,206,37,88,114,156,232,108,87,66,168,239,94,199,134,148,4,134,170,99,179,249,238,191,63,223,253,78,20,43,81,215,140,35,236,144,136,233,42,55,209,188,82,185,40,44,49,35,42,245,48,60,61,12,7,86,11,85,192,251,81,27,44,167,189,179,211,75,137,188,17,235,104,133,10,73,240,31,205,181,45,161,171,187,206,152,176,112,106,216,40,131,148,187,151,79,96,179,44,153,144,107,166,15,243,170,172,43,141,228,149,113,28,67,162,109,89,50,58,166,231,243,150,170,79,145,161,6,86,11,200,43,2,108,70,193,237,161,89,129,112,112,30,174,201,153,228,150,201,134,42,186,24,197,87,78,181,221,75,193,65,92,16,238,18,12,78,158,162,5,126,65,115,168,50,61,129,173,159,14,205,62,163,47,192,27,26,75,74,183,56,109,70,129,76,50,131,25,236,143,103,248,154,145,187,8,135,162,163,214,50,238,123,38,94,5,202,41,103,35,235,0,221,69,169,96,58,74,19,141,8,156,48,159,141,62,186,173,56,117,91,106,195,20,199,40,137,189,199,125,75,143,50,74,151,125,162,155,33,10,187,157,149,55,27,186,129,139,162,25,217,44,149,45,145,216,94,98,162,13,185,143,34,133,21,154,181,31,123,236,194,66,119,173,103,104,47,101,177,123,13,89,61,77,127,19,123,134,57,179,210,120,184,127,153,120,47,228,16,108,147,235,34,108,222,100,246,247,112,199,168,178,240,205,251,243,87,248,109,59,69,95,187,126,190,1,25,108,11,25,75,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4ee924f-2761-4cad-9702-50f6fc4e2bb2"));
		}

		#endregion

	}

	#endregion

}

