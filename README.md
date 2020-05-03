# Introduction
This repository exists to try out algorithms to build anomaly detectors using PCA. The repository consists of a `Dockefile` that would help launch a jupyter notebook. The jupyter notebook will be used to run notebooks to try out anomaly detectors that use PCA.

# Run
Build the docker image to run Jupyter notebook.
```bash
docker-compose build jupyter
```
The above command will end up creating a docker image with the tag: `ubuntu-18.04:jupyter`

Run the jupyter notebook:
```bash
docker-compose up jupyter
```

Find the access token URI of the jupyter notebook session:
```bash
docker-compose exec jupyter jupyter notebook list
```

Connect to the jupyter notebook using the following URL:
```
http://localhost:9145/?token=<token>
```

**NOTE:** The docker container already maps the container port 9145 to the same port accessible through localhost. Hence, whatever URI you obtain from running the command `jupyter notebook list` you will replace the domain name of the URI with `localhost` to make the URI accessible.

# Notebooks
Currently there is a single notebook in this repository `learn-pca-fft.ipynb` which is mounted as a volume in the container and can be directly accessed from the browser when accessing jupyter running in the container.