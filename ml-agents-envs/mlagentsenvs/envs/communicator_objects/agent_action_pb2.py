# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mlagentsenvs/envs/communicator_objects/agent_action.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
from google.protobuf import descriptor_pb2
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='mlagentsenvs/envs/communicator_objects/agent_action.proto',
  package='communicator_objects',
  syntax='proto3',
  serialized_pb=_b('\n9mlagentsenvs/envs/communicator_objects/agent_action.proto\x12\x14\x63ommunicator_objects\"K\n\x10\x41gentActionProto\x12\x16\n\x0evector_actions\x18\x01 \x03(\x02\x12\r\n\x05value\x18\x04 \x01(\x02J\x04\x08\x02\x10\x03J\x04\x08\x03\x10\x04J\x04\x08\x05\x10\x06\x42\x1f\xaa\x02\x1cMLAgents.CommunicatorObjectsb\x06proto3')
)




_AGENTACTIONPROTO = _descriptor.Descriptor(
  name='AgentActionProto',
  full_name='communicator_objects.AgentActionProto',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='vector_actions', full_name='communicator_objects.AgentActionProto.vector_actions', index=0,
      number=1, type=2, cpp_type=6, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='value', full_name='communicator_objects.AgentActionProto.value', index=1,
      number=4, type=2, cpp_type=6, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=83,
  serialized_end=158,
)

DESCRIPTOR.message_types_by_name['AgentActionProto'] = _AGENTACTIONPROTO
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

AgentActionProto = _reflection.GeneratedProtocolMessageType('AgentActionProto', (_message.Message,), dict(
  DESCRIPTOR = _AGENTACTIONPROTO,
  __module__ = 'mlagentsenvs.envs.communicator_objects.agent_action_pb2'
  # @@protoc_insertion_point(class_scope:communicator_objects.AgentActionProto)
  ))
_sym_db.RegisterMessage(AgentActionProto)


DESCRIPTOR.has_options = True
DESCRIPTOR._options = _descriptor._ParseOptions(descriptor_pb2.FileOptions(), _b('\252\002\034MLAgents.CommunicatorObjects'))
# @@protoc_insertion_point(module_scope)
