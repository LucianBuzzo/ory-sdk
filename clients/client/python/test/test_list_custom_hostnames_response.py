"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v0.0.1-alpha.140
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.cname_settings import CnameSettings
globals()['CnameSettings'] = CnameSettings
from ory_client.model.list_custom_hostnames_response import ListCustomHostnamesResponse


class TestListCustomHostnamesResponse(unittest.TestCase):
    """ListCustomHostnamesResponse unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testListCustomHostnamesResponse(self):
        """Test ListCustomHostnamesResponse"""
        # FIXME: construct object with mandatory attributes with example values
        # model = ListCustomHostnamesResponse()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
