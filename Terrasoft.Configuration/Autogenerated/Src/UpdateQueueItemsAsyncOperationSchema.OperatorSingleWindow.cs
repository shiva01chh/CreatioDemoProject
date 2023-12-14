﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateQueueItemsAsyncOperationSchema

	/// <exclude/>
	public class UpdateQueueItemsAsyncOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateQueueItemsAsyncOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateQueueItemsAsyncOperationSchema(UpdateQueueItemsAsyncOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69242731-0c77-4b1b-9e5a-124fa41acd25");
			Name = "UpdateQueueItemsAsyncOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("64ebcdcc-1a9c-4eb3-9403-16c8221d18f7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,77,79,219,64,16,61,7,137,255,176,77,47,142,100,57,119,72,34,69,33,160,168,106,11,77,232,5,113,88,236,113,216,202,94,187,251,145,214,66,252,247,206,206,218,198,54,132,246,208,28,72,118,119,222,155,153,55,31,72,158,131,46,121,12,108,7,74,113,93,164,38,90,21,50,21,123,171,184,17,133,60,61,121,58,61,25,89,45,228,158,109,43,109,32,63,31,156,209,62,203,32,118,198,58,186,2,9,74,196,47,54,171,66,65,255,20,173,165,17,70,128,142,150,186,146,241,215,18,188,39,253,143,102,209,70,26,80,41,198,60,68,92,242,216,20,74,116,239,187,89,117,56,143,26,108,141,143,23,223,63,42,216,163,63,182,202,184,214,103,236,182,76,184,129,27,11,22,54,152,181,238,71,69,136,233,116,202,102,218,230,57,87,213,162,62,19,154,89,2,107,246,211,193,153,112,120,230,253,207,52,0,139,21,164,243,241,134,162,171,214,7,144,166,207,62,158,46,152,200,203,12,114,124,162,155,168,113,55,237,248,43,237,67,38,98,22,147,203,247,227,101,103,236,184,59,164,122,162,132,90,13,62,131,121,44,18,84,225,154,92,248,71,242,47,228,35,22,220,36,69,252,215,44,162,245,111,136,173,129,224,86,131,194,38,147,190,105,80,136,238,49,100,71,9,150,106,175,25,87,123,235,100,208,19,84,197,133,81,103,125,40,68,194,254,179,7,230,122,127,52,58,112,229,43,183,108,94,216,156,5,36,237,187,76,147,150,233,156,120,54,43,30,63,2,181,24,227,101,137,81,147,41,221,34,99,63,202,104,57,176,240,28,87,22,211,4,242,186,73,16,212,186,240,189,141,151,222,174,120,248,129,60,76,147,179,249,43,119,119,13,69,180,43,182,70,97,39,6,147,123,143,20,41,11,60,236,195,156,73,155,101,141,12,164,3,189,124,231,153,117,172,193,39,168,232,247,53,23,106,230,66,11,217,5,118,221,78,228,176,152,232,122,150,70,93,82,50,143,16,231,216,251,162,70,173,120,155,164,245,57,82,96,172,146,53,205,51,125,249,191,216,104,136,83,252,33,131,153,207,125,225,9,93,117,6,204,84,171,186,10,41,70,129,18,176,192,131,154,153,148,53,184,245,76,74,211,29,9,77,191,162,107,37,220,180,225,202,179,185,164,92,234,200,52,137,232,173,190,224,82,29,34,46,132,46,51,126,28,152,138,12,183,26,138,199,91,228,21,152,93,85,66,210,193,204,188,245,34,24,95,146,253,58,17,198,97,198,147,62,155,175,238,22,11,157,243,58,154,97,163,188,60,246,161,220,143,204,43,9,151,116,127,254,210,9,94,46,191,102,110,141,200,104,177,34,142,54,158,95,197,149,203,97,118,243,150,225,34,144,240,235,238,190,45,51,158,112,137,75,12,194,58,100,227,55,24,247,167,98,28,14,198,100,82,55,70,35,192,155,81,97,17,10,252,119,161,125,230,237,78,164,177,13,218,146,133,77,181,195,87,250,133,237,200,133,181,64,97,167,98,181,111,223,150,195,73,139,190,65,94,28,32,120,99,224,60,238,185,94,181,32,19,191,109,233,236,111,251,151,116,135,159,63,183,163,196,15,181,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69242731-0c77-4b1b-9e5a-124fa41acd25"));
		}

		#endregion

	}

	#endregion

}

