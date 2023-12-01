namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCounterSchema

	/// <exclude/>
	public class INotificationCounterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCounterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCounterSchema(INotificationCounterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b7d7230-b757-4090-bbb0-2b97d1bc90cb");
			Name = "INotificationCounter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,77,78,195,48,16,133,215,173,212,59,140,202,6,164,42,217,67,200,166,72,85,54,8,1,23,112,156,73,106,17,219,209,120,92,20,33,238,142,237,52,109,213,10,175,236,241,243,247,230,199,70,104,116,131,144,8,159,72,36,156,109,57,219,90,211,170,206,147,96,101,205,106,249,179,90,46,188,83,166,131,143,209,49,234,167,171,115,208,247,61,202,40,118,217,14,13,146,146,65,19,84,119,132,93,136,66,101,24,169,13,38,143,80,189,90,86,173,146,137,189,181,62,222,36,109,158,231,80,56,175,181,160,177,60,158,223,200,30,84,131,14,4,104,228,189,109,128,45,116,200,192,123,4,227,117,141,4,182,5,115,129,116,80,143,208,145,245,67,54,67,243,11,234,224,235,94,73,80,115,66,255,228,179,136,53,223,164,148,2,239,200,158,130,205,165,41,200,233,97,50,151,214,176,144,156,157,8,249,53,162,24,4,9,13,38,180,254,121,125,148,87,205,186,220,78,91,8,37,155,8,71,202,138,60,105,207,79,105,178,47,95,84,106,120,192,110,224,123,143,132,240,133,35,40,55,213,30,187,146,114,2,97,26,56,136,222,99,188,75,161,192,156,33,145,90,157,73,133,99,10,99,221,196,246,148,176,67,190,233,205,253,206,171,6,78,41,63,196,175,240,59,141,26,77,51,77,123,181,12,145,176,254,0,43,108,173,48,90,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7d7230-b757-4090-bbb0-2b97d1bc90cb"));
		}

		#endregion

	}

	#endregion

}

