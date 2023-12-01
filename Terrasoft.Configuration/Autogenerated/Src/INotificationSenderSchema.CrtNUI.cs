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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,65,106,195,48,16,69,215,49,248,14,34,171,118,99,29,32,174,55,165,20,111,74,33,185,128,34,143,147,1,107,100,102,164,64,40,185,123,37,145,150,168,21,218,72,243,255,251,159,33,227,64,86,99,65,29,128,217,136,159,67,247,234,105,198,83,100,19,208,83,219,124,181,205,38,10,210,73,237,175,18,192,165,249,178,128,205,67,233,222,129,128,209,238,218,38,169,180,214,170,151,232,156,225,235,112,127,127,178,191,224,4,162,4,104,202,16,242,1,103,180,5,46,202,65,56,251,73,186,31,183,126,176,175,241,184,160,85,72,1,120,206,21,199,143,7,239,62,241,128,147,44,247,251,23,93,62,178,68,234,192,238,87,172,255,170,251,213,176,113,138,210,70,94,182,149,105,59,28,206,80,113,82,169,217,179,187,51,123,93,172,133,116,241,56,149,224,167,241,141,162,3,54,199,5,250,170,249,152,188,67,93,235,57,45,112,115,107,155,116,211,249,6,190,178,248,13,149,1,0,0 };
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

