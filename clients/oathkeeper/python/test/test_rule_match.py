"""
    ORY Oathkeeper

    ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.  # noqa: E501

    The version of the OpenAPI document: v0.38.18-beta.1
    Contact: hi@ory.am
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_oathkeeper_client
from ory_oathkeeper_client.model.rule_match import RuleMatch


class TestRuleMatch(unittest.TestCase):
    """RuleMatch unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testRuleMatch(self):
        """Test RuleMatch"""
        # FIXME: construct object with mandatory attributes with example values
        # model = RuleMatch()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
