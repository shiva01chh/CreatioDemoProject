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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,177,110,194,48,16,134,231,68,202,59,156,88,128,197,81,59,180,67,17,11,234,144,14,68,106,187,85,29,156,112,70,150,108,31,242,217,80,68,121,247,198,73,105,35,33,188,216,119,190,239,238,255,237,200,218,109,225,237,200,1,237,83,145,23,185,147,22,121,39,91,132,119,244,94,50,169,32,86,228,148,222,70,47,131,38,87,228,167,34,207,202,178,132,5,71,107,165,63,46,127,227,202,5,244,42,161,138,60,56,10,90,233,182,103,0,191,176,141,233,36,46,108,57,130,63,234,134,201,96,192,217,228,81,220,61,136,123,248,30,53,59,104,99,160,65,240,104,105,143,27,144,170,187,129,13,38,0,20,202,16,61,194,116,61,26,199,181,171,29,174,140,100,126,161,102,42,38,243,207,110,202,46,54,70,183,160,255,26,87,99,166,114,138,158,123,149,228,187,226,83,122,139,236,202,102,159,88,223,116,118,109,109,200,120,236,68,58,94,190,14,251,63,4,28,100,64,177,40,47,21,9,105,136,12,12,90,112,54,239,126,37,59,23,249,57,9,74,235,7,182,174,234,151,178,1,0,0 };
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

