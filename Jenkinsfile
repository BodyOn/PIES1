pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Pipeline rodando'
        mail(subject: '[Jenkins] Pipeline - BodyOn', body: 'Pipeline foi iniciado, este é um email de verificação.', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com')
      }
    }

  }
}