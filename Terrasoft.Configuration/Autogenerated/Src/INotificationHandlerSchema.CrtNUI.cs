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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,78,195,48,12,134,207,171,212,119,176,118,130,203,242,0,43,189,32,4,189,160,73,219,11,120,153,51,34,37,78,229,36,72,211,196,187,147,182,3,86,26,249,18,219,255,247,219,102,244,20,123,212,4,7,18,193,24,76,218,60,7,54,246,156,5,147,13,92,87,215,186,90,229,104,249,12,251,75,76,228,75,221,57,210,67,49,110,94,137,73,172,222,214,85,233,82,74,65,19,179,247,40,151,246,246,239,56,145,152,193,192,4,129,94,130,166,56,194,56,36,107,172,198,137,243,163,86,119,242,62,31,157,213,96,127,9,221,251,157,230,13,249,228,72,74,223,48,224,194,123,76,236,38,59,138,75,183,165,221,148,233,81,208,3,151,179,60,173,103,162,117,251,183,55,4,3,233,131,254,81,27,53,138,71,214,103,176,39,152,70,124,232,94,56,123,18,60,58,106,102,43,116,108,66,59,135,60,150,75,174,190,234,170,68,121,223,25,115,115,246,158,1,0,0 };
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

