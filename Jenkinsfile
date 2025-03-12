pipeline {
    agent any
    stages {
        stage('Front copy') {
            steps {
                sh 'cp /var/lib/jenkins/workspace/Diplom_test/Dockerfile-front /var/lib/jenkins/workspace/Diplom_test/FrontEnd/my-app/Dockerfile'
            }
        }
        stage('Docker-build-front') {
            steps {
                sh 'sudo docker build -t front /var/lib/jenkins/workspace/Diplom_test/FrontEnd/my-app/'
            }
        }
        stage('docker run front') {
            steps {
                sh 'sudo docker run -d -p 81:80 front'
            }
        }
        stage('Bek copy') {
            steps {
                sh 'cp /var/lib/jenkins/workspace/Diplom_test/Dockerfile-bek /var/lib/jenkins/workspace/Diplom_test/BackEnd/Amazon-clone/Dockerfile'
            }
        }
        stage('Docker-build-bek') {
            steps {
                sh 'sudo docker build -t bek /var/lib/jenkins/workspace/Diplom_test/BackEnd/Amazon-clone/'
            }
        }
        stage('docker run bek') {
            steps {
                sh 'sudo docker run -d -p 5034:5034 bek'
            }
        }
    }
}
