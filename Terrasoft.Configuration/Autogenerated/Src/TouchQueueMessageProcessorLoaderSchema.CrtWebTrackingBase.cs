﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageProcessorLoaderSchema

	/// <exclude/>
	public class TouchQueueMessageProcessorLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageProcessorLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageProcessorLoaderSchema(TouchQueueMessageProcessorLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d82fe34-a6a1-4613-a17e-ba392938c2ae");
			Name = "TouchQueueMessageProcessorLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,219,78,27,49,16,125,14,82,255,97,154,74,40,145,208,230,189,100,35,81,4,109,36,40,20,130,120,68,206,102,54,113,241,218,193,151,208,20,241,239,29,123,47,201,110,110,244,37,90,219,51,103,102,206,156,177,35,89,134,102,206,18,132,17,106,205,140,74,109,116,174,100,202,167,78,51,203,149,252,116,244,246,233,168,229,12,151,83,184,95,26,139,217,105,99,77,246,66,96,226,141,77,244,29,37,106,158,108,216,92,113,249,178,177,121,135,105,225,184,58,90,79,35,203,118,157,104,220,181,31,93,178,196,42,205,209,144,5,217,124,209,56,165,0,112,46,152,49,95,97,164,92,50,251,229,208,225,53,26,195,166,120,171,85,66,95,74,95,41,54,65,29,124,122,189,30,244,141,203,50,166,151,131,98,29,252,193,42,16,100,103,128,9,1,108,193,184,96,99,129,180,77,168,240,226,97,33,203,113,97,94,2,155,168,132,236,173,97,206,221,88,240,4,146,0,123,56,171,214,91,200,108,85,14,145,109,181,243,165,82,85,183,1,44,183,104,38,31,54,134,146,91,206,4,255,139,6,36,190,2,39,111,38,169,235,42,5,59,195,60,141,168,114,239,53,253,251,115,166,89,6,146,212,18,183,157,65,77,241,101,222,186,246,224,129,214,144,84,27,21,120,212,239,5,183,128,82,212,123,168,210,206,67,13,28,234,177,186,224,197,216,106,61,213,183,33,110,216,157,6,43,95,116,5,63,90,206,209,116,186,225,228,189,224,18,229,36,167,179,206,237,37,71,49,241,172,106,190,96,22,243,195,121,190,0,42,205,82,29,26,217,68,73,177,4,53,254,77,49,225,73,168,228,249,38,255,142,3,197,249,65,136,184,197,127,120,33,93,134,218,171,167,239,83,27,192,211,188,150,106,195,173,65,203,211,70,189,251,10,186,70,59,83,59,43,26,43,37,224,7,51,161,53,21,95,103,214,106,62,118,22,59,62,29,176,244,83,178,175,209,58,45,195,22,205,187,61,119,198,170,172,178,55,29,127,160,210,206,170,213,155,160,221,19,32,245,98,55,224,181,162,155,212,7,233,239,243,24,116,186,209,153,92,214,59,88,150,176,201,38,229,213,108,61,188,65,8,183,96,26,94,149,126,14,215,158,63,35,195,5,39,237,81,227,194,148,231,55,200,210,215,214,31,62,110,179,28,20,105,4,44,242,192,108,44,150,33,12,97,108,197,246,96,235,18,44,73,172,57,71,143,51,212,24,248,131,120,144,115,19,88,30,154,123,55,14,51,122,147,150,244,126,99,6,119,79,83,183,160,182,117,124,188,175,183,161,173,91,41,93,40,62,129,109,19,84,136,128,167,208,105,72,22,62,147,242,157,16,165,73,81,99,94,239,123,248,245,83,66,126,171,97,169,108,63,130,87,3,44,16,67,11,26,126,241,182,246,23,94,205,24,113,195,57,26,169,43,110,108,105,255,190,133,154,253,204,195,57,221,13,118,181,30,22,183,225,206,57,58,163,17,38,92,165,163,220,179,114,240,182,39,205,81,239,146,100,14,100,240,145,59,110,117,37,28,122,58,238,66,150,255,247,226,65,74,60,36,78,107,148,182,146,248,190,231,37,167,194,12,60,245,254,77,234,27,164,71,73,99,26,183,247,215,218,238,13,170,247,198,208,131,83,2,173,61,57,11,174,173,99,162,118,73,236,7,173,95,31,43,205,215,164,102,138,123,222,167,124,8,175,84,83,67,124,209,165,210,23,44,153,149,19,95,234,220,199,169,94,232,120,167,160,130,150,10,89,175,253,219,56,155,76,134,233,79,101,47,254,80,102,166,83,2,149,130,174,223,63,43,191,61,170,201,119,235,155,97,239,232,232,31,145,150,169,138,64,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d82fe34-a6a1-4613-a17e-ba392938c2ae"));
		}

		#endregion

	}

	#endregion

}
