"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.1.10
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.project_services import ProjectServices
globals()['ProjectServices'] = ProjectServices
from ory_client.model.set_project import SetProject


class TestSetProject(unittest.TestCase):
    """SetProject unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testSetProject(self):
        """Test SetProject"""
        # FIXME: construct object with mandatory attributes with example values
        # model = SetProject()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()