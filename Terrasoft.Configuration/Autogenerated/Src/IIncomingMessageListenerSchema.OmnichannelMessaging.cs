namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncomingMessageListenerSchema

	/// <exclude/>
	public class IIncomingMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncomingMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncomingMessageListenerSchema(IIncomingMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4621d47-b46b-4fa0-8ceb-e6a359374028");
			Name = "IIncomingMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,193,78,195,48,12,134,207,171,212,119,176,198,5,46,205,125,148,93,118,170,196,96,66,240,0,166,117,187,72,141,83,197,41,18,66,188,59,105,210,86,163,81,46,249,243,251,211,111,155,209,144,12,88,19,188,147,115,40,182,245,197,201,114,171,187,209,161,215,150,139,87,195,186,190,34,51,245,197,153,68,176,211,220,229,217,79,158,229,217,238,206,81,23,76,80,177,39,215,6,204,1,170,138,107,107,130,39,153,233,197,122,221,106,114,209,175,148,130,82,70,99,208,125,31,231,247,27,13,142,132,216,11,232,5,3,173,117,208,107,241,196,129,20,244,132,4,147,152,82,192,2,83,55,180,97,252,236,117,125,67,217,102,121,142,196,41,203,46,229,95,27,56,147,191,218,70,14,112,137,140,244,185,77,27,133,75,96,91,103,4,176,158,230,3,225,110,227,21,107,177,218,86,151,3,58,52,192,97,236,79,251,217,190,63,86,91,64,169,162,47,150,125,89,221,192,199,208,160,167,251,117,1,115,67,75,193,195,227,220,14,113,147,58,138,239,223,180,164,127,98,208,166,243,7,184,254,192,44,249,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4621d47-b46b-4fa0-8ceb-e6a359374028"));
		}

		#endregion

	}

	#endregion

}

