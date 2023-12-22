namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationSenderSchema

	/// <exclude/>
	public class INotificationSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationSenderSchema(INotificationSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0434505-a3a8-488e-a33b-2a071c2954f0");
			Name = "INotificationSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,65,106,195,48,16,69,215,49,248,14,34,171,118,99,29,160,174,55,165,20,111,74,33,185,128,34,143,147,1,107,100,102,164,64,40,189,123,37,145,22,171,21,218,72,243,255,251,159,33,227,64,86,99,65,29,129,217,136,159,67,247,226,105,198,115,100,19,208,83,219,124,182,205,46,10,210,89,29,110,18,192,165,249,178,128,205,67,233,222,128,128,209,62,181,77,82,105,173,85,47,209,57,195,183,225,254,254,96,127,197,9,68,9,208,148,33,228,3,206,104,11,92,148,131,112,241,147,116,63,110,189,177,175,241,180,160,85,72,1,120,206,21,199,247,141,247,144,120,192,73,150,251,253,139,46,31,89,34,117,96,247,43,214,127,213,253,106,216,56,69,105,35,207,251,202,180,31,142,23,168,56,169,212,236,217,221,153,189,46,214,66,186,122,156,74,240,195,248,74,209,1,155,211,2,125,213,124,76,222,161,174,245,152,22,184,251,106,155,116,183,231,27,226,47,214,42,158,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0434505-a3a8-488e-a33b-2a071c2954f0"));
		}

		#endregion

	}

	#endregion

}

