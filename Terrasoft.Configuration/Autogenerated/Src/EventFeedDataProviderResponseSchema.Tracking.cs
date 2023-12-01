namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventFeedDataProviderResponseSchema

	/// <exclude/>
	public class EventFeedDataProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventFeedDataProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventFeedDataProviderResponseSchema(EventFeedDataProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf4ac696-3045-4224-8196-29e9ed1c351b");
			Name = "EventFeedDataProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,193,110,194,48,12,61,131,196,63,88,112,111,239,192,184,192,182,203,36,16,227,7,178,212,233,162,181,73,101,167,72,12,237,223,231,38,45,170,38,132,150,67,21,59,239,61,191,231,58,85,35,55,74,35,156,144,72,177,55,33,219,122,103,108,217,146,10,214,187,236,68,74,127,89,87,206,166,215,217,116,210,178,92,225,253,194,1,107,1,86,21,234,14,197,217,43,58,36,171,87,179,169,160,22,132,165,116,97,91,41,230,37,60,159,209,133,23,196,98,167,130,58,144,63,219,2,233,40,115,133,136,145,144,231,57,172,185,173,107,69,151,77,95,15,0,208,157,10,24,79,2,65,41,9,205,211,92,94,125,75,26,199,146,243,124,3,202,21,96,221,167,120,9,88,36,42,114,214,75,238,78,123,208,222,5,101,29,3,161,246,84,36,225,179,229,86,85,246,27,133,155,16,58,128,17,199,3,115,157,143,220,53,237,71,101,117,239,235,97,56,88,194,253,204,147,107,204,125,219,148,32,26,164,96,81,214,117,136,242,233,253,239,98,98,99,111,12,99,0,111,134,12,217,13,58,182,57,248,228,64,221,79,235,89,87,40,49,172,128,187,207,207,131,33,93,164,255,233,191,89,14,235,219,26,142,145,178,73,123,225,123,227,22,232,138,20,59,214,169,59,110,198,142,156,95,42,89,70,42,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf4ac696-3045-4224-8196-29e9ed1c351b"));
		}

		#endregion

	}

	#endregion

}

