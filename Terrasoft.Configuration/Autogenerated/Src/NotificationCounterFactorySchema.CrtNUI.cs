namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationCounterFactorySchema

	/// <exclude/>
	public class NotificationCounterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationCounterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationCounterFactorySchema(NotificationCounterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b249d9e1-6ca1-4cdb-b5cf-9f2e4cc638b6");
			Name = "NotificationCounterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,111,219,48,12,61,59,64,254,3,225,94,92,160,176,239,205,7,80,4,107,144,195,138,98,31,231,65,113,104,71,152,44,25,148,148,33,40,246,223,39,201,118,226,184,78,186,45,200,69,20,249,248,222,35,101,201,42,212,53,203,17,190,33,17,211,170,48,233,74,201,130,151,150,152,225,74,78,39,111,211,73,100,53,151,37,124,61,106,131,149,187,23,2,115,127,169,211,53,74,36,158,207,78,57,125,152,170,82,114,252,134,240,90,60,125,102,185,81,196,81,251,12,247,191,35,44,93,43,88,9,166,245,35,188,40,195,11,158,7,110,43,101,165,65,106,42,142,211,137,203,206,178,12,230,218,86,21,163,227,178,61,191,146,58,240,29,106,96,80,161,217,171,29,24,5,44,207,81,107,48,123,132,220,35,187,235,66,17,148,104,140,39,21,226,13,188,78,59,220,172,7,92,219,173,224,121,83,123,131,20,60,194,230,22,229,232,45,242,34,79,42,159,57,138,157,147,249,74,252,192,12,6,77,81,221,28,128,144,237,148,20,71,248,174,145,220,148,100,51,5,248,97,47,206,179,166,234,14,229,174,65,109,207,157,145,110,110,134,172,39,224,27,5,29,109,159,70,211,117,190,201,160,241,101,223,123,240,171,18,69,151,209,116,181,199,252,231,19,149,182,66,105,94,172,16,137,116,75,167,138,100,80,125,63,11,213,3,49,176,128,119,234,162,232,247,109,137,159,195,152,175,217,184,249,36,29,23,98,91,129,243,177,225,44,97,141,102,36,174,55,206,56,38,221,222,36,206,64,191,37,37,41,91,119,178,15,140,128,119,25,142,118,88,216,214,56,247,78,204,147,16,227,237,146,0,243,16,64,34,137,191,250,19,234,124,75,226,75,23,226,135,225,212,59,255,8,141,37,121,102,242,111,126,245,182,97,248,148,66,224,75,64,215,61,161,170,112,89,232,94,11,97,177,136,199,4,198,217,18,182,199,126,86,63,105,237,197,187,148,83,203,108,216,115,94,51,98,21,248,173,89,196,193,171,120,249,1,216,60,11,53,103,136,198,21,189,60,127,187,254,142,248,60,235,42,123,15,228,191,23,104,116,111,218,129,125,184,115,77,209,181,113,182,177,126,200,69,220,239,15,84,249,25,135,226,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b249d9e1-6ca1-4cdb-b5cf-9f2e4cc638b6"));
		}

		#endregion

	}

	#endregion

}

