#from distutils.core import setup, Extension
from setuptools import setup
from setuptools.extension import Extension

pctx_module = Extension('_pctx',
                        sources=['pctx.cc', 'pctx.i'],
                        swig_opts=['-c++'],
                        libraries=['libusb-1.0'],
                        library_dirs=['.'],
                        include_dirs=['.'],
                        language='c++')

setup(name='python-pctx',
      version='0.1',
      ext_modules=[pctx_module],
      py_modules=['pctx'])