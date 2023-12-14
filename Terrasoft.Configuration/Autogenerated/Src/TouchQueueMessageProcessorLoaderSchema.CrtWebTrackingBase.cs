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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,219,110,26,49,16,125,38,82,255,97,154,74,17,72,209,242,222,0,18,69,73,139,148,52,105,66,148,71,100,150,89,112,227,181,137,47,164,52,202,191,119,236,189,192,46,183,148,7,132,237,153,227,153,51,103,198,72,150,162,89,176,24,97,132,90,51,163,18,27,13,148,76,248,204,105,102,185,146,159,78,222,62,157,52,156,225,114,6,15,43,99,49,189,168,173,201,94,8,140,189,177,137,190,163,68,205,227,45,155,107,46,95,182,54,239,49,201,29,215,71,155,97,164,233,190,19,141,251,246,163,43,22,91,165,57,26,178,32,155,47,26,103,116,1,12,4,51,230,43,140,148,139,231,191,28,58,188,65,99,216,12,239,180,138,233,151,210,215,138,77,81,7,159,118,187,13,29,227,210,148,233,85,47,95,7,127,176,10,4,217,25,96,66,0,91,50,46,216,68,32,109,19,42,188,120,88,72,51,92,88,20,192,38,42,32,219,27,152,11,55,17,60,134,56,192,30,143,170,241,22,34,91,167,67,100,91,237,124,170,148,213,93,0,203,44,234,193,135,141,161,228,150,51,193,255,162,1,137,175,192,201,155,73,170,186,74,192,206,49,11,35,42,221,219,117,255,206,130,105,150,130,36,181,116,79,157,65,77,247,203,172,116,167,189,71,90,67,92,110,148,224,81,167,29,220,2,74,158,239,177,76,155,143,21,112,168,222,213,2,47,198,70,99,92,221,134,110,205,238,34,88,249,164,75,248,209,106,129,166,217,10,39,239,57,151,40,167,25,157,85,110,175,56,138,169,103,85,243,37,179,152,29,46,178,5,80,106,150,242,208,200,166,74,138,21,168,201,111,186,19,198,66,197,207,183,217,239,110,160,56,59,8,55,238,240,31,94,74,151,162,246,234,233,248,208,122,48,94,84,66,173,185,213,104,25,111,229,123,40,161,27,180,115,181,55,163,137,82,2,126,48,19,74,83,242,213,183,86,243,137,179,216,244,225,128,165,175,130,125,141,214,105,25,182,168,223,237,192,25,171,210,210,222,52,253,129,74,154,235,82,111,131,182,206,129,212,139,173,128,215,136,110,19,127,73,231,144,71,175,217,138,250,114,85,173,96,145,194,54,155,20,87,189,244,240,6,225,186,37,211,240,170,244,115,24,123,254,140,12,151,156,180,71,133,11,93,158,77,144,149,207,173,51,124,218,101,217,203,195,8,88,228,129,233,68,172,194,53,132,177,19,219,131,109,74,176,32,177,226,28,61,205,81,99,224,15,186,189,140,155,192,242,208,60,184,73,232,209,219,164,160,247,27,51,184,191,155,90,57,181,141,179,179,67,181,13,101,221,73,233,82,241,41,236,234,160,92,4,60,129,102,77,178,240,153,148,239,132,40,76,242,28,179,124,223,195,183,239,18,242,91,55,75,105,251,17,188,10,96,142,24,74,80,243,235,238,42,127,238,85,191,163,91,115,142,70,234,154,27,91,216,191,239,160,230,48,243,48,160,217,96,215,235,97,62,13,247,246,81,159,90,152,112,149,142,50,207,210,193,219,158,215,91,189,69,146,57,18,193,71,102,220,122,36,28,123,58,238,67,148,255,247,226,65,66,60,196,78,107,148,182,148,248,161,231,37,163,194,244,60,245,254,77,234,24,164,71,73,99,210,61,61,156,235,105,187,87,190,55,134,30,156,2,104,227,201,89,114,109,29,19,149,33,113,24,180,58,62,214,154,175,72,205,228,115,222,135,124,12,175,80,83,77,124,209,149,210,151,44,158,23,29,95,232,220,223,83,190,208,221,189,130,10,90,202,101,189,241,111,163,63,157,14,147,159,202,94,254,161,200,76,179,0,42,4,93,157,63,107,191,3,170,201,118,171,155,97,143,62,255,0,215,12,85,181,65,10,0,0 };
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

