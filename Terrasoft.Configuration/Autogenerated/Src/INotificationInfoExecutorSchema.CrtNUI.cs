namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoExecutorSchema

	/// <exclude/>
	public class INotificationInfoExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoExecutorSchema(INotificationInfoExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70829de2-1828-4038-881b-1a16b2b88f30");
			Name = "INotificationInfoExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,177,110,194,48,16,134,231,68,202,59,156,88,128,197,81,59,180,67,17,11,234,144,14,68,106,187,85,29,156,112,70,150,28,31,242,217,80,68,121,247,218,73,105,35,33,188,216,119,190,239,238,255,237,192,218,110,225,237,200,30,187,167,34,47,114,43,59,228,157,108,17,222,209,57,201,164,188,88,145,85,122,27,156,244,154,108,145,159,138,60,43,203,18,22,28,186,78,186,227,242,55,174,172,71,167,18,170,200,129,37,175,149,110,123,6,240,11,219,144,78,226,194,150,35,248,163,110,152,12,122,156,77,30,197,221,131,184,135,239,81,179,131,54,6,26,4,135,29,237,113,3,82,197,27,216,96,2,64,161,244,193,33,76,215,163,113,92,219,218,226,202,72,230,23,106,166,98,50,255,140,83,118,161,49,186,5,253,215,184,26,51,149,85,244,220,171,36,23,139,79,233,45,178,43,155,125,98,125,211,217,181,181,33,227,48,138,180,188,124,29,246,127,8,216,75,143,98,81,94,42,18,210,16,25,24,180,224,108,30,127,37,59,23,249,57,9,138,235,7,39,78,29,55,177,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70829de2-1828-4038-881b-1a16b2b88f30"));
		}

		#endregion

	}

	#endregion

}

