define("SocialFeed", ["OperatorSingleWindowSocialMessageViewModel"], function() {
		return {
			methods: {

				/**
				 * @inheritdoc Terrasoft.SocialFeedUtilities#getSocialMessageViewModelName
				 */
				getSocialMessageViewModelName: function() {
					return "Terrasoft.OperatorSingleWindowSocialMessageViewModel";
				}

			}
		};
	});
